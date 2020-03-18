using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CernerCMove
{
    public partial class Form1 : MaterialForm
    {
        // this is we can get the fileversion of the exe; then we'll set the console.title to reflect this value 
        public static string AppVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();


        public Form1()
        {
            InitializeComponent();

            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);

            // the below wil invoke the material design
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            // now we'll set the version that'll display on the main screen
            labelVersion.Text = AppVersion;

            // this method will check if the Logs dir exists in the exe root
            // and create it if it's not 
            GlobalVars.CreateLogDirectory();

            // hide the below fields on startup
            sourceVerifyProgress.Visible = false;
            targetVerifyProgress.Visible = false;
            searchMrnAccProgress.Visible = false;
            searchResultsProgress.Visible = false;
            pictureBoxSearchFailed.Visible = false;
            label18.Visible = false;
            label17.Visible = false;
            pictureBox7.Visible = false;
            LabelCAMM6SourceDBCheckValue.Visible = false;
            pictureBoxCAMMSourceDBCheck.Visible = false;
            label4.Visible = false;
            pictureBox4.Visible = false;
            pictureBox9.Visible = false;
            label19.Visible = false;

        }

        private async void sourceVerifyBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(sourceHostIP.Text))
            {
                MessageBox.Show("Please enter a Source Hostname/IP first. ", "Error: Verify Source Hostname/IP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sourceHostIP.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(sourceAET.Text))
            {
                MessageBox.Show("Please enter a Source AET first. ", "Error: Verify Source AET", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sourceAET.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(sourcePort.Text))
            {
                MessageBox.Show("Please enter a Source Port first. ", "Error: Verify Source Port", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sourcePort.Focus();
                return;
            }
            if (sourceTransferSyntax1.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a transfer syntax first. ", "Error: Verify Transfer Syntax", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sourceTransferSyntax1.Focus();
                return;
            }

            var transferSyntax = "";
            var transferSyntaxValue = "";
            if (sourceTransferSyntax1.SelectedIndex == 0)
            {
                transferSyntax = "1";
                transferSyntaxValue = "Implicit Little Endian";
            }
            else 
            {
                transferSyntax = "2";
                transferSyntaxValue = "Explicit Little Endian";
            }

            sourceVerifyProgress.Visible = true;
            GlobalVars.SourceAETCechoSuccess = false;
            LabelCAMM6SourceDBCheckValue.Visible = false;
            pictureBoxCAMMSourceDBCheck.Visible = false;
            var currentDate = DateTime.Now;
            string sourceAETCechoTestResults = "";

            connectLogWindow.AppendText("------------------------------------------------------------------------------------------------------------------------------------------------------ \r\n");
            connectLogWindow.AppendText($"[{currentDate}] START SOURCE CECHO TEST - Host:{sourceHostIP.Text} | Port:{sourcePort.Text} | AET: {sourceAET.Text} | Transfer Syntax: {transferSyntaxValue}\r\n");

            await Task.Run(() =>
             {
                 sourceAETCechoTestResults = (CechoAET(sourceHostIP.Text, sourcePort.Text, sourceAET.Text, transferSyntax));
             });
            
            connectLogWindow.AppendText(sourceAETCechoTestResults);
            connectLogWindow.AppendText("------------------------------------------------------------------------------------------------------------------------------------------------------ \r\n");

            if (sourceAETCechoTestResults.Contains("Received Echo Response (Success)"))
            {
                GlobalVars.SourceAETCechoSuccess = true;
                GlobalVars.SourceAETAfterTest = sourceAET.Text;
                GlobalVars.SourceHostIPAfterTest = sourceHostIP.Text;
                GlobalVars.SourcePortAfterTest = sourcePort.Text;

                LabelCAMM6SourceDBCheckValue.Visible = true;
                pictureBoxCAMMSourceDBCheck.Visible = true;

                // we'll now populate the search camm selection dropdown 
                // we'll now populate the search camm selection dropdown 
                for (int i = 0; i < searchCAMMSelect.Items.Count; ++i)
                {
                    var line = searchCAMMSelect.Items[i].ToString();

                    if (line.Contains("[SOURCE]"))
                    {
                        searchCAMMSelect.Items.Remove(line);
                    }
                }

                searchCAMMSelect.Items.Add("[SOURCE] " + sourceHostIP.Text);
            }
            else
            {
                GlobalVars.SourceAETCechoSuccess = false;
                searchCAMMSelect.Items.Clear();
            }

            sourceVerifyProgress.Visible = false;

        }

        public string CechoAET(string _hostname, string _port, string _aet, string _transferSyntax)
        {
            // we'll verify if the PACS is Online and then cecho
            StringBuilder sb = new StringBuilder();

            try
            {
                var SourceAETCEcho = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = $"{GlobalVars.ApplicationStartPath}\\echoscu.exe",
                        //Arguments = $"-v {_hostname} {_port} -aec {_aet} -aet MoveAET",
                        Arguments = $"-v -pts {_transferSyntax} {_hostname} {_port} -aec {_aet} -aet {utilityAET.Text.Trim()}",
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true
                    }
                };

                SourceAETCEcho.Start();

                while (!SourceAETCEcho.StandardOutput.EndOfStream)
                {

                    //var line = SourceAETCEcho.StandardOutput.ReadLine();

                    sb.AppendLine("    " + SourceAETCEcho.StandardOutput.ReadLine());
                    //sb.AppendLine("\r\n");

                    //cechoAETResponse.Add(line + "\r\n");
                    //textBoxActions.AppendText(line + "\r\n");

                }

                SourceAETCEcho.WaitForExit();
            }
            catch (Exception e1)
            {
                connectLogWindow.AppendText(e1.Message);
            }

            return sb.ToString();
        }

        private void connectLogWindowOpen_Click(object sender, EventArgs e)
        {
            // we'll create/re-rewrite a text file with the texbox text for the user to view
            try
            {
                File.Delete(GlobalVars.connectLogFile);
                File.WriteAllLines(GlobalVars.connectLogFile, new[] { connectLogWindow.Text });
                System.Diagnostics.Process.Start(GlobalVars.connectLogFile);
            }
            catch (Exception outputFileCrateError)
            {

                MessageBox.Show("There was an error while attempting to create the output file! \r\n" +
                            $"Error: {outputFileCrateError.Message} \r\n\r\n" + "Please check that you're able to write to folder where this exe lives, and try again.",
                            "ERROR: Unable to crate Output Log file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void connectLogWindowClear_Click(object sender, EventArgs e)
        {
            connectLogWindow.Clear();
        }

        private async void targetVerifyBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(targetHostIP.Text))
            {
                MessageBox.Show("Please enter a Target Hostname/IP first. ", "Error: Verify Target Hostname/IP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                targetHostIP.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(targetAET.Text))
            {
                MessageBox.Show("Please enter a Target AET first. ", "Error: Verify Target AET", MessageBoxButtons.OK, MessageBoxIcon.Error);
                targetAET.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(targetPort.Text))
            {
                MessageBox.Show("Please enter a Target Port first. ", "Error: Verify Target Port", MessageBoxButtons.OK, MessageBoxIcon.Error);
                targetPort.Focus();
                return;
            }
            if (targetTransferSyntax2.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a transfer syntax first. ", "Error: Verify Transfer Syntax", MessageBoxButtons.OK, MessageBoxIcon.Error);
                targetTransferSyntax2.Focus();
                return;
            }

            if (targetTransferSyntax2.SelectedIndex == 0)
            {
                GlobalVars.TransferSyntax = "1";
                GlobalVars.TransferSyntaxValue = "Implicit Little Endian";
            }
            else
            {
                GlobalVars.TransferSyntax = "2";
                GlobalVars.TransferSyntaxValue = "Explicit Little Endian";
            }

            targetVerifyProgress.Visible = true;
            GlobalVars.TargetAETCechoSuccess = false;
            label4.Visible = false;
            pictureBox4.Visible = false;
            var currentDate = DateTime.Now;
            string targetAETCechoTestResults = "";

            connectLogWindow.AppendText("------------------------------------------------------------------------------------------------------------------------------------------------------ \r\n");
            connectLogWindow.AppendText($"[{currentDate}] START TARGET CECHO TEST - Host:{targetHostIP.Text} | Port:{targetPort.Text} | AET: {targetAET.Text} | Transfer Syntax: {GlobalVars.TransferSyntaxValue}\r\n");

            await Task.Run(() =>
            {
                targetAETCechoTestResults = (CechoAET(targetHostIP.Text, targetPort.Text, targetAET.Text, GlobalVars.TransferSyntax));
            });
            
            connectLogWindow.AppendText(targetAETCechoTestResults);
            connectLogWindow.AppendText("------------------------------------------------------------------------------------------------------------------------------------------------------ \r\n");

            if (targetAETCechoTestResults.Contains("Received Echo Response (Success)"))
            {
                GlobalVars.TargetAETCechoSuccess = true;
                GlobalVars.targetAETAfterTest = targetAET.Text;
                GlobalVars.targetHostIPAfterTest = targetHostIP.Text;
                GlobalVars.targetPortAfterTest = targetPort.Text;

                label4.Visible = true;
                pictureBox4.Visible = true;

                // we'll now populate the search camm selection dropdown 
                for (int i = 0; i < searchCAMMSelect.Items.Count; ++i)
                {
                    var line = searchCAMMSelect.Items[i].ToString();

                    if (line.Contains("[TARGET]"))
                    {
                        searchCAMMSelect.Items.Remove(line);
                    }
                }

                searchCAMMSelect.Items.Add("[TARGET] " + targetHostIP.Text);
            }
            else
            {
                GlobalVars.TargetAETCechoSuccess = false;
                searchCAMMSelect.Items.Clear();
            }

            targetVerifyProgress.Visible = false;
        }

        //----------------------------------------------------------------------\\ SEARCH TAB //----------------------------------------------------------------------

        private void searchCAMMSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

            // we'll update the AET and PORT based on the selction the user picks
            if (searchCAMMSelect.Text.Contains("[SOURCE]")) 
            {
                searchCAMMAET.Text = GlobalVars.SourceAETAfterTest;
                searchCAMMPort.Text = GlobalVars.SourcePortAfterTest;
                GlobalVars.searchHostIPValue = GlobalVars.SourceHostIPAfterTest;
                GlobalVars.searchAETValue = GlobalVars.SourceAETAfterTest;
                GlobalVars.searchPortValue = GlobalVars.SourcePortAfterTest;


            }
            else
            {
                searchCAMMAET.Text = GlobalVars.targetAETAfterTest;
                searchCAMMPort.Text = GlobalVars.targetPortAfterTest;
                GlobalVars.searchHostIPValue = GlobalVars.targetHostIPAfterTest;
                GlobalVars.searchAETValue = GlobalVars.targetAETAfterTest;
                GlobalVars.searchPortValue = GlobalVars.targetPortAfterTest;
            }

        }

        private async void materialFlatButton1_Click(object sender, EventArgs e)
        {
            searchMrnAccProgress.Visible = true;

            if (searchCAMMSelect.SelectedIndex < 0)
            {
                MessageBox.Show($"Please select a CAMM server first.", "CAMM Server Field Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(searchACCtxtbox.Text) && string.IsNullOrWhiteSpace(searchMRNtxtbox.Text))
            {
                MessageBox.Show($"Please enter an MRN or Accession first.", "MRN and Accession Field Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!string.IsNullOrWhiteSpace(searchACCtxtbox.Text) && !string.IsNullOrWhiteSpace(searchMRNtxtbox.Text))
            {
                MessageBox.Show($"Please enter MRN or Accession, not both.", "MRN and Accession Populated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((searchACCtxtbox.Text == "*") || (searchMRNtxtbox.Text == "*"))
            {
                MessageBox.Show($"Full WildCard Searches are NOT allowed; only partial ones can be used!", "Full Wildcard Detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            metroGrid1.Rows.Clear();
            pictureBox7.Visible = false;
            label17.Visible = false;
            pictureBoxSearchFailed.Visible = false;
            label18.Visible = false;

            var patientFindResults = "";
            var accessionFindResults = "";

            if (!string.IsNullOrWhiteSpace(searchACCtxtbox.Text))
            {
                GlobalVars.searchAccStringValue = searchACCtxtbox.Text;

                await Task.Run(() =>
                {
                    accessionFindResults = (FindAccessionNumber(GlobalVars.searchHostIPValue, GlobalVars.searchAETValue,
                      GlobalVars.searchPortValue, GlobalVars.searchAccStringValue, utilityAET.Text.Trim()));
                });

                // check how many studies were found based on the PID
                int studyCount = Regex.Matches(accessionFindResults, "D: [(]0020,000d[)] UI [[]").Count;

                var afterSBTrim = accessionFindResults.ToString().Replace("\0", "");

                //if ((patientFindResults.Contains("Received Final Find Response (Success)") && ((patientFindResults.Contains("I: (0010,0010) PN [")) || patientFindResults.Contains($"I: (0010,0020) LO [{GlobalVars.searchMRNStringValue} ]"))))
                if ((afterSBTrim.Contains("D: DIMSE Status                  : 0x0000: Success")) && (afterSBTrim.Contains("D: (0020,000d) UI [")))
                {
                    GlobalVars.AccessionFindResultsSuccess = true;

                    pictureBox7.Visible = true;
                    label17.Visible = true;
                    label17.Text = $"[SUCCESS] {studyCount} Studies Found for Accession {GlobalVars.searchAccStringValue}!";

                    //var newRow = new List<string>();
                    //var newRow = new List<KeyValuePair<string, string>>();
                    ////List<List<string>> newRow = new List<List<string>>();

                    using (StringReader reader = new StringReader(afterSBTrim))
                    {
                        string line = string.Empty;
                        var outputPNremoveCarrot = "";
                        var outputMRNpost = "";
                        var outputAccpost = "";
                        var outputDTpost = "";
                        var outputSUIDpost = "";
                        var outputAApost = "";
                        var outputStudyDescpost = "";
                        var outputModalityTypepost = "";
                        do
                        {
                            line = reader.ReadLine();
                            if (line != null)
                            {
                                if (line.Contains($"D: (0010,0020) LO ["))
                                {
                                    string outputMRNpre = line.Substring(line.IndexOf('[') + 1);
                                    outputMRNpost = outputMRNpre.Remove(outputMRNpre.IndexOf("]")); ;
                                    //newRow.Add(outputMRNpost);
                                }
                                else if (line.Contains("D: (0010,0010) PN ["))
                                {
                                    string outputPNpre = line.Substring(line.IndexOf('[') + 1);
                                    string outputPNpost = outputPNpre.Remove(outputPNpre.IndexOf("]") - 1); ;
                                    outputPNremoveCarrot = outputPNpost.Replace("^", ",");
                                    //newRow.Add(outputPNremoveCarrot);
                                }
                                else if (line.Contains("D: (0010,0021) LO ["))
                                {
                                    string outputAApre = line.Substring(line.IndexOf('[') + 1);
                                    outputAApost = outputAApre.Remove(outputAApre.IndexOf("]")); ;
                                }
                                else if (line.Contains("D: (0010,0021) LO ("))
                                {
                                    outputAApost = "N/A";
                                }
                                else if (line.Contains("D: (0008,0050) SH ["))
                                {
                                    string outputAccpre = line.Substring(line.IndexOf('[') + 1);
                                    outputAccpost = outputAccpre.Remove(outputAccpre.IndexOf("]"));
                                }
                                else if (line.Contains("D: (0008,0050) SH ("))
                                {
                                    outputAccpost = "N/A";
                                }
                                else if (line.Contains("D: (0008,0060) CS ["))
                                {
                                    string outputModalityTypepre = line.Substring(line.IndexOf('[') + 1);
                                    outputModalityTypepost = outputModalityTypepre.Remove(outputModalityTypepre.IndexOf("]"));
                                
                                }
                                else if (line.Contains("D: (0008,0060) CS ("))
                                {
                                    outputModalityTypepost = "N/A";
                                }
                                else if (line.Contains("D: (0008,0020) DA ["))
                                {
                                    string outputDTpre = line.Substring(line.IndexOf('[') + 1);
                                    outputDTpost = outputDTpre.Remove(outputDTpre.IndexOf("]"));
                                    outputDTpost = outputDTpost.Insert(4, "-");
                                    outputDTpost = outputDTpost.Insert(7, "-");

                                }
                                else if (line.Contains("D: (0008,1030) LO ["))
                                {
                                    string outputStudyDescpre = line.Substring(line.IndexOf('[') + 1);
                                    outputStudyDescpost = outputStudyDescpre.Remove(outputStudyDescpre.IndexOf("]"));
                                }
                                else if (line.Contains("D: (0008,1030) LO ("))
                                {
                                    outputStudyDescpost = "N/A";
                                }
                                else if (line.Contains("D: (0020,000d) UI ["))
                                {
                                    string outputSUIDpre = line.Substring(line.IndexOf('[') + 1);
                                    outputSUIDpost = outputSUIDpre.Remove(outputSUIDpre.IndexOf("]"));
                                }

                                if ((!string.IsNullOrEmpty(outputMRNpost)) && (!string.IsNullOrEmpty(outputPNremoveCarrot))
                                      && (!string.IsNullOrEmpty(outputAccpost))
                                      && (!string.IsNullOrEmpty(outputDTpost))
                                      && (!string.IsNullOrEmpty(outputSUIDpost))
                                      && (!string.IsNullOrEmpty(outputAApost))
                                      && (!string.IsNullOrEmpty(outputStudyDescpost))
                                      && (!string.IsNullOrEmpty(outputModalityTypepost)))
                                {
                                    metroGrid1.Rows.Add(outputPNremoveCarrot, outputMRNpost, outputAccpost, outputModalityTypepost, outputStudyDescpost, outputDTpost, outputSUIDpost, outputAApost);
                                    outputPNremoveCarrot = "";
                                    outputMRNpost = "";
                                    outputAccpost = "";
                                    outputDTpost = "";
                                    outputSUIDpost = "";
                                    outputAApost = "";
                                    outputStudyDescpost = "";
                                    outputModalityTypepost = "";
                                }
                            }

                        } while (line != null);
                    }

                    searchMrnAccProgress.Visible = false;
                }
                else
                {
                    GlobalVars.PatientFindResultsSuccess = false;
                    searchMrnAccProgress.Visible = false;
                    pictureBoxSearchFailed.Visible = true;
                    label18.Visible = true;
                    label18.Text = $"[FAILURE] Unable to Query/Find Accession {GlobalVars.searchAccStringValue}";

                }

            }
            else
            {
                searchMrnAccProgress.Visible = false;

                GlobalVars.searchMRNStringValue = searchMRNtxtbox.Text;
                await Task.Run(() =>
                {
                    patientFindResults = (FindPatID(GlobalVars.searchHostIPValue, GlobalVars.searchAETValue,
                      GlobalVars.searchPortValue, GlobalVars.searchMRNStringValue, utilityAET.Text.Trim()));
                });

                // check how many studies were found based on the PID
                int studyCount = Regex.Matches(patientFindResults, "D: [(]0020,000d[)] UI [[]").Count;

                var afterSBTrim = patientFindResults.ToString().Replace("\0", "");

                //if ((patientFindResults.Contains("Received Final Find Response (Success)") && ((patientFindResults.Contains("I: (0010,0010) PN [")) || patientFindResults.Contains($"I: (0010,0020) LO [{GlobalVars.searchMRNStringValue} ]"))))
                if ((afterSBTrim.Contains("D: DIMSE Status                  : 0x0000: Success")))
                {
                    GlobalVars.PatientFindResultsSuccess = true;

                    pictureBox7.Visible = true;
                    label17.Visible = true;
                    label17.Text = $"[SUCCESS] {studyCount} Studies Found for ID {GlobalVars.searchMRNStringValue}!";

                    //var newRow = new List<string>();
                    //var newRow = new List<KeyValuePair<string, string>>();
                    ////List<List<string>> newRow = new List<List<string>>();

                    using (StringReader reader = new StringReader(afterSBTrim))
                    {
                        string line = string.Empty;
                        var outputPNremoveCarrot = "";
                        var outputMRNpost = "";
                        var outputAccpost = "";
                        var outputDTpost = "";
                        var outputSUIDpost = "";
                        var outputAApost = "";
                        var outputStudyDescpost = "";
                        var outputModalityTypepost = "";
                        do
                        {
                            line = reader.ReadLine();
                            if (line != null)
                            {
                                if (line.Contains($"D: (0010,0020) LO ["))
                                {
                                    string outputMRNpre = line.Substring(line.IndexOf('[') + 1);
                                    outputMRNpost = outputMRNpre.Remove(outputMRNpre.IndexOf("]")); ;
                                    //newRow.Add(outputMRNpost);
                                }
                                else if (line.Contains("D: (0010,0010) PN ["))
                                {
                                    string outputPNpre = line.Substring(line.IndexOf('[') + 1);
                                    string outputPNpost = outputPNpre.Remove(outputPNpre.IndexOf("]") - 1); ;
                                    outputPNremoveCarrot = outputPNpost.Replace("^", ",");
                                    //newRow.Add(outputPNremoveCarrot);
                                }
                                else if (line.Contains("D: (0010,0021) LO ["))
                                {
                                    string outputAApre = line.Substring(line.IndexOf('[') + 1);
                                    outputAApost = outputAApre.Remove(outputAApre.IndexOf("]")); ;
                                }
                                else if (line.Contains("D: (0010,0021) LO ("))
                                {
                                    outputAApost = "N/A";
                                }
                                else if (line.Contains("D: (0008,0050) SH ["))
                                {
                                    string outputAccpre = line.Substring(line.IndexOf('[') + 1);
                                    outputAccpost = outputAccpre.Remove(outputAccpre.IndexOf("]"));
                                }
                                else if (line.Contains("D: (0008,0050) SH ("))
                                {
                                    outputAccpost = "N/A";
                                }
                                else if (line.Contains("D: (0008,0060) CS ["))
                                {
                                    string outputModalityTypepre = line.Substring(line.IndexOf('[') + 1);
                                    outputModalityTypepost = outputModalityTypepre.Remove(outputModalityTypepre.IndexOf("]"));

                                }
                                else if (line.Contains("D: (0008,0060) CS ("))
                                {
                                    outputModalityTypepost = "N/A";
                                }
                                else if (line.Contains("D: (0008,0020) DA ["))
                                {
                                    string outputDTpre = line.Substring(line.IndexOf('[') + 1);
                                    outputDTpost = outputDTpre.Remove(outputDTpre.IndexOf("]"));
                                    outputDTpost = outputDTpost.Insert(4, "-");
                                    outputDTpost = outputDTpost.Insert(7, "-");

                                }
                                else if (line.Contains("D: (0008,1030) LO ["))
                                {
                                    string outputStudyDescpre = line.Substring(line.IndexOf('[') + 1);
                                    outputStudyDescpost = outputStudyDescpre.Remove(outputStudyDescpre.IndexOf("]"));
                                }
                                else if (line.Contains("D: (0008,1030) LO ("))
                                {
                                    outputStudyDescpost = "N/A";
                                }
                                else if (line.Contains("D: (0020,000d) UI ["))
                                {
                                    string outputSUIDpre = line.Substring(line.IndexOf('[') + 1);
                                    outputSUIDpost = outputSUIDpre.Remove(outputSUIDpre.IndexOf("]"));
                                }

                                if ((!string.IsNullOrEmpty(outputMRNpost)) && (!string.IsNullOrEmpty(outputPNremoveCarrot))
                                         && (!string.IsNullOrEmpty(outputAccpost))
                                         && (!string.IsNullOrEmpty(outputDTpost))
                                         && (!string.IsNullOrEmpty(outputSUIDpost))
                                         && (!string.IsNullOrEmpty(outputAApost))
                                         && (!string.IsNullOrEmpty(outputStudyDescpost))
                                         && (!string.IsNullOrEmpty(outputModalityTypepost)))
                                {
                                    metroGrid1.Rows.Add(outputPNremoveCarrot, outputMRNpost, outputAccpost, outputModalityTypepost, outputStudyDescpost, outputDTpost, outputSUIDpost, outputAApost);
                                    outputPNremoveCarrot = "";
                                    outputMRNpost = "";
                                    outputAccpost = "";
                                    outputDTpost = "";
                                    outputSUIDpost = "";
                                    outputAApost = "";
                                    outputStudyDescpost = "";
                                    outputModalityTypepost = "";
                                }
                            }
                           
                        } while (line != null);
                    }

                    searchMrnAccProgress.Visible = false;
                }
                else
                {
                    GlobalVars.PatientFindResultsSuccess = false;
                    searchMrnAccProgress.Visible = false;
                    pictureBoxSearchFailed.Visible = true;
                    label18.Visible = true;
                    label18.Text = $"[FAILURE] Unable to Query/Find PATIENT ID {GlobalVars.searchMRNStringValue}";

                }

                searchMrnAccProgress.Visible = false;
            }
           
        }

        // we'll create the method to find the Patient ID the user has entered
        public static string FindPatID(string CAMMHostname, string CAMMAET, string CAMMPort, string PatID, string CallingAET)
        {
            StringBuilder sb = new StringBuilder();

            var trSynToUse = ""; // we'll use this for CAMM 7 if ILE is not allowed. 
            if (GlobalVars.TransferSyntax == "1")
            {
                trSynToUse = "xi";
            }
            else
            {
                trSynToUse = "xe";
            }

            try
            {
                var FindMRN = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = $"{Application.StartupPath}\\findscu.exe",
                        //Arguments = $"-v {_hostname} {_port} -aec {_aet} -aet MoveAET",
                        //Arguments = $"-v {_hostname} {_port} -aec {_aet} -aet CERNMIGECHO",
                        //Arguments = $"-v -P -xi -d -k 0008,0052=PATIENT -k 0010,0020=\"{PatID}\" {CAMMHostname} {CAMMPort} -aec {CAMMAET} -aet {CallingAET}",
                        Arguments = $"-d -S -{trSynToUse} -k 0008,0052=SERIES -k 0010,0020=\"{PatID}\" -k 0010,0010 -k 0010,0021 -k 0008,0050 -k 0008,1030 -k 0008,0060 -k 0008,0020 {CAMMHostname} {CAMMPort} -aec {CAMMAET} -aet {CallingAET}",
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true
                    }
                };

                FindMRN.Start();

                while (!FindMRN.StandardOutput.EndOfStream)
                {

                    //var line = SourceAETCEcho.StandardOutput.ReadLine();

                    sb.AppendLine("    " + FindMRN.StandardOutput.ReadLine());
                    //sb.AppendLine("\r\n");

                    //cechoAETResponse.Add(line + "\r\n");
                    //textBoxActions.AppendText(line + "\r\n");

                }

                FindMRN.WaitForExit();

                GlobalVars.PatientFindResultsSuccess = true;
            }
            catch (Exception e1)
            {
                // we will fill this globalvar string with the error message and then on the UserControl we'll update the text box for the user
                GlobalVars.FindMRNFailure = e1.Message;
            }

            // we'll save the output to the log file
            try
            {
                File.Delete(GlobalVars.searchMRNResults);
                File.WriteAllLines(GlobalVars.searchMRNResults, new[] { sb.ToString() });
            }
            catch (Exception outputFileCrateError)
            {

                MessageBox.Show("There was an error while attempting to create the search MRN output file! \r\n" +
                            $"Error: {outputFileCrateError.Message} \r\n\r\n" + "Please check that you're able to write to folder where this exe lives, and try again.",
                            "ERROR: Unable to crate search MRN output Log file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return sb.ToString();
        }

        // we'll create the method to find the Accssion number the user has entered
        public static string FindAccessionNumber(string CAMMHostname, string CAMMAET, string CAMMPort, string AccessionNumber, string CallingAET)
        {
            StringBuilder sb = new StringBuilder();
            var trSynToUse = ""; // we'll use this for CAMM 7 if ILE is not allowed. 
            if (GlobalVars.TransferSyntax == "1")
            {
                trSynToUse = "xi";
            }
            else
            {
                trSynToUse = "xe";
            }

            try
            {
                //// we'll try to create the file first before trying to use it
                //if (!File.Exists(GlobalVars.CFindAccessionResultsTextFile))
                //{
                //    File.Create(GlobalVars.CFindAccessionResultsTextFile).Close();
                //}

                var FindAccessionNumber = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = $"{Application.StartupPath}\\findscu.exe",
                        //Arguments = $"-v {_hostname} {_port} -aec {_aet} -aet MoveAET",
                        //Arguments = $"-v {_hostname} {_port} -aec {_aet} -aet CERNMIGECHO",
                        //Arguments = $"-v -P -xi -d -k 0008,0052=PATIENT -k 0010,0020=\"{PatID}\" {CAMMHostname} {CAMMPort} -aec {CAMMAET} -aet {CallingAET}",
                        Arguments = $"-d -S -{trSynToUse} -k 0008,0052=SERIES -k 0008,0050=\"{AccessionNumber}\" -k 0010,0010 -k 0010,0021 -k 0008,1030 -k 0008,0020 -k 0008,0060 {CAMMHostname} {CAMMPort} -aec {CAMMAET} -aet {CallingAET}",
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true
                    }
                };

                FindAccessionNumber.Start();

                while (!FindAccessionNumber.StandardOutput.EndOfStream)
                {

                    //var line = SourceAETCEcho.StandardOutput.ReadLine();
                    sb.AppendLine("    " + FindAccessionNumber.StandardOutput.ReadLine());
                    //sb.AppendLine("\r\n");

                    //cechoAETResponse.Add(line + "\r\n");
                    //textBoxActions.AppendText(line + "\r\n");

                }

                FindAccessionNumber.WaitForExit();

            }
            catch (Exception e1)
            {
                // we will fill this globalvar string with the error message and then on the UserControl we'll update the text box for the user
                GlobalVars.FindAccessionNumberFailure = e1.Message;

            }

            // we'll save the output to the log file
            try
            {
                File.Delete(GlobalVars.searchAccessionResults);
                File.WriteAllLines(GlobalVars.searchAccessionResults, new[] { sb.ToString() });
            }
            catch (Exception outputFileCrateError)
            {

                MessageBox.Show("There was an error while attempting to create the search Accession output file! \r\n" +
                            $"Error: {outputFileCrateError.Message} \r\n\r\n" + "Please check that you're able to write to folder where this exe lives, and try again.",
                            "ERROR: Unable to crate search Accession output Log file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return sb.ToString();
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            DateTime ftime = File.GetLastWriteTime(GlobalVars.searchMRNResults);
            DateTime ftime2 = File.GetLastWriteTime(GlobalVars.searchAccessionResults);

            if (ftime > ftime2)
            {
                System.Diagnostics.Process.Start(GlobalVars.searchMRNResults);
            }
            else
            {
                System.Diagnostics.Process.Start(GlobalVars.searchAccessionResults);
            }
        }

        private async void materialFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var process in Process.GetProcessesByName("storescp"))
                {
                    process.Kill();
                }
            }
            catch (Exception)
            {


            }
            var patientName = metroGrid1.SelectedRows[0].Cells[0].Value;
            var patientMRN = metroGrid1.SelectedRows[0].Cells[1].Value;
            var patientAcc = metroGrid1.SelectedRows[0].Cells[2].Value;
            var patientSUID = metroGrid1.SelectedRows[0].Cells[6].Value;

            //// user elected to cmove data!
            //metroGrid1.Enabled = false;
            //searchCAMMSelect.Enabled = false;
            //searchMRNtxtbox.Enabled = false;
            //searchACCtxtbox.Enabled = false;
            //materialFlatButton2.Enabled = false;

            var args = "";
            StringBuilder sb = new StringBuilder();
            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            var storescpSTDOut = "";

            var trSynToUse = ""; // we'll use this for CAMM 7 if ILE is not allowed. 
            if (GlobalVars.TransferSyntax == "1")
            {
                trSynToUse = "xi";
            }
            else
            {
                trSynToUse = "xe";
            }

            if (metroGrid1.SelectedRows.Count > 0)
            {
                searchResultsProgress.Visible = true;
                if (MessageBox.Show($"Are you sure you want to send data between the two below listed PACS systems? \r\n\r\n" +
                                $"Source AET: {GlobalVars.SourceAETAfterTest} \r\n" +
                                $"Source Hostname: {GlobalVars.SourceHostIPAfterTest} \r\n\r\n" +
                                $"Target AET: {GlobalVars.targetAETAfterTest} \r\n" +
                                $"Target Hostname: {GlobalVars.targetHostIPAfterTest}\r\n\r\n" +
                                $"Transfer Syntax: {GlobalVars.TransferSyntaxValue} \r\n" +
                                $"Patient Name: {patientName}\r\n" +
                                $"Patient MRN: {patientMRN}\r\n" +
                                $"Patient Acc.: {patientAcc}\r\n" +
                                $"Patient SUID: {patientSUID}\r\n", "Question: Confirm DICOM Data Migration", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    //textBoxActions.AppendText($"     UPDATE: User elected not to begin DICOM Migration. \n\n");
                    searchResultsProgress.Visible = false;
                    return;
                }
                else
                {
                    // we'll create the dir to store the dcm files
                    var saveDCMFolder = $@"{GlobalVars.downloadedDicomDataLocation}{patientMRN}";
                    if (!Directory.Exists(saveDCMFolder))
                    {
                        Directory.CreateDirectory(saveDCMFolder);
                    }

                    args = $"{GlobalVars.SourceHostIPAfterTest} {GlobalVars.SourcePortAfterTest} -S -{trSynToUse} -v -aet {utilityAET.Text.Trim()} " +
                                    $"-aec {GlobalVars.SourceAETAfterTest} -aem {utilityAET.Text.Trim()} -k 0008,0052=\"STUDY\" " +
                                    $"-k 0020,000d=\"{patientSUID}\"";

                    //DownloadDICOMStudy(patientSUID.ToString(), args);

                    try
                    {
                        pictureBox9.Visible = true;
                        label19.Text = "Starting StoreSCP Services...";
                        label19.Visible = true;

                        await Task.Run(() =>
                        {
                            System.Diagnostics.Process process1 = new System.Diagnostics.Process();
                            process1.StartInfo.FileName = $"{GlobalVars.ApplicationStartPath}\\storescp.exe";
                            process1.StartInfo.Arguments = $"104 -v -aet CERNERDCMS -od {saveDCMFolder}";
                            process1.StartInfo.UseShellExecute = false;
                            //process1.StartInfo.RedirectStandardOutput = true;
                            process1.StartInfo.CreateNoWindow = true;
                            //process1.EnableRaisingEvents = true;
                            process1.Start();
                            //storescpSTDOut = await process1.StandardOutput.ReadToEndAsync();


                            //process1.WaitForExit();

                            //var DownloadStudySCP = new Process
                            //{
                            //    StartInfo = new ProcessStartInfo
                            //    {
                            //        FileName = $"{GlobalVars.ApplicationStartPath}\\storescp.exe",
                            //        Arguments = $"104 -d -aet CERNERDCMS -od {saveDCMFolder}",
                            //        UseShellExecute = false,
                            //        RedirectStandardOutput = true,
                            //        CreateNoWindow = true
                            //    }
                            //};

                            //DownloadStudySCP.Start();

                            //while (!DownloadStudySCP.StandardOutput.EndOfStream)
                            //{

                            //    sb.AppendLine("    " + DownloadStudySCP.StandardOutput.ReadLine());

                            //    //var line = DownloadStudySCP.StandardOutput.ReadLine();

                            //    ////if ((line.Contains("error") || (line.Contains("Warning"))))
                            //    //if ((line.Contains("error")))
                            //    //{

                            //    //    // if the user elected to save an error log, we'll append this error to the error log the user selected
                            //    //    File.AppendAllLines(GlobalVars.migrationErrorLogLocation, new[] { " ERROR: " + DateTime.Now.ToString() + " | " + line + "\r\n" });
                            //    //}

                            //}

                            //DownloadStudySCP.WaitForExit();

                            var DownloadStudy = new Process
                            {
                                StartInfo = new ProcessStartInfo
                                {
                                    FileName = $"{GlobalVars.ApplicationStartPath}\\movescu.exe",
                                    Arguments = args,
                                    UseShellExecute = false,
                                    RedirectStandardOutput = true,
                                    CreateNoWindow = true
                                }
                            };

                            DownloadStudy.Start();

                            

                            while (!DownloadStudy.StandardOutput.EndOfStream)
                            {

                                sb1.AppendLine("    " + DownloadStudy.StandardOutput.ReadLine());

                            }

                            DownloadStudy.WaitForExit();

                            try
                            {
                                process1.Kill();
                                process1.Close();
                            }
                            catch (Exception)
                            {
                                
                            }

                            
                            //DownloadStudySCP.WaitForExit();
                            //DownloadStudySCP.Close();
                        });

                        pictureBox9.Visible = true;
                        label19.Text = "MoveSCU Services Started...";
                        label19.Visible = true;
                    }
                    catch (Exception e2)
                    {
                        File.AppendAllLines(GlobalVars.storeSCPLog, new[] { " Application Error: " + DateTime.Now.ToString() + " | " + e2.Message + "\r\n" });
                    }

                    //we'll save the output to the log file
                    try
                    {
                        //File.Delete(GlobalVars.searchAccessionResults);
                        File.AppendAllLines(GlobalVars.moveSCULog, new[] {
                    "---------------\r\n" + DateTime.Now.ToString() + "| C-Move START | Source Host: " + GlobalVars.SourceHostIPAfterTest + " | Source AET: " + GlobalVars.SourcePortAfterTest +
                    " | Target AET: CERNERDCMS" + " | Target PORT: 104 \r\n" +
                    sb1.ToString() + "\r\n" + "---------------\r\n\r\n" });
                    }
                    catch (Exception outputFileCrateError)
                    {

                        MessageBox.Show("There was an error while attempting to create the STORESCU Log file! \r\n" +
                                    $"Error: {outputFileCrateError.Message} \r\n\r\n" + "Please check that you're able to write to folder where this exe lives, and try again.",
                                    "ERROR: Unable to crate STORESCU Log file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    //we'll save the output to the log file
                    try
                    {
                        //File.Delete(GlobalVars.searchAccessionResults);
                        File.Delete(GlobalVars.storeSCPLog);
                        File.AppendAllLines(GlobalVars.storeSCPLog, new[] {
                                "---------------\r\n" + DateTime.Now.ToString() + "| STORESCP START \r\n"+
                                storescpSTDOut + "\r\n" + "---------------\r\n\r\n" });
                    }
                    catch (Exception outputFileCrateError)
                    {

                        MessageBox.Show("There was an error while attempting to create the STORESCP Log file! \r\n" +
                                    $"Error: {outputFileCrateError.Message} \r\n\r\n" + "Please check that you're able to write to folder where this exe lives, and try again.",
                                    "ERROR: Unable to crate STORESCP Log file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // we'll check if the study was downloaded successfully
                    if (sb1.ToString().Contains("I: Received Final Move Response (Success)"))
                    {
                        //pictureBox7.Visible = true;
                        //label17.Text = "Successfully Fetched Data; will send to Target now..."
                        //label17.Visible = false;
                        pictureBox9.Visible = true;
                        label19.Text = "Successfully Fetched Data; will send to Target now...";
                        label19.Visible = true;
                    }

                    // now we'll send the data to the target AET
                    try
                    {
                        args = $@"-d  -{trSynToUse} +sd -aec {GlobalVars.targetAETAfterTest} -aet {utilityAET.Text.Trim()} {GlobalVars.targetHostIPAfterTest} {GlobalVars.targetPortAfterTest} {saveDCMFolder}";

                        pictureBox9.Visible = true;
                        label19.Text = "StoreSCU Services Started...";
                        label19.Visible = true;

                        await Task.Run(() =>
                        {
                            var sendStudyToTarget = new Process
                            {
                                StartInfo = new ProcessStartInfo
                                {
                                    FileName = $"{GlobalVars.ApplicationStartPath}\\storescu.exe",
                                    Arguments = args,
                                    UseShellExecute = false,
                                    RedirectStandardOutput = true,
                                    CreateNoWindow = true
                                }
                            };

                            sendStudyToTarget.Start();

                            while (!sendStudyToTarget.StandardOutput.EndOfStream)
                            {

                                sb2.AppendLine("    " + sendStudyToTarget.StandardOutput.ReadLine());

                                //var line1 = DownloadStudy.StandardOutput.ReadLine();

                                ////if ((line.Contains("error") || (line.Contains("Warning"))))
                                //if ((line1.Contains("error")))
                                //{

                                //    // if the user elected to save an error log, we'll append this error to the error log the user selected
                                //    File.AppendAllLines(GlobalVars.moveSCULog, new[] { DateTime.Now.ToString() + " | " + line1 + "\r\n" });
                                //}

                            }

                            sendStudyToTarget.WaitForExit();

                        });

                        pictureBox9.Visible = false;
                        label19.Visible = false;
                      
                    }
                    catch (Exception e3)
                    {
                        MessageBox.Show($"There was an error while attempting to send the study the target ({GlobalVars.targetHostIPAfterTest}! \r\n" +
                                    $"Error: {e3.Message} \r\n\r\n" + "Please check logs to view full details.",
                                    $"ERROR: Unable to send to target ({GlobalVars.targetHostIPAfterTest}) STORESCU Log file", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        if (!saveDCMFilesLocallyCheckBox.Checked)
                        {
                            // we'll clear the recently downloaded folder
                            if (Directory.Exists(saveDCMFolder))
                            {
                                Directory.Delete(saveDCMFolder, true);
                            }
                        }
                        

                    }

                    //we'll save the output to the log file
                    try
                    {
                        //File.Delete(GlobalVars.searchAccessionResults);
                        File.Delete(GlobalVars.storeSCULog);
                        File.AppendAllLines(GlobalVars.storeSCULog, new[] {
                                "---------------\r\n" + DateTime.Now.ToString() + "| STORESCU START \r\n"+
                                sb2.ToString() + "\r\n" + "---------------\r\n\r\n" });
                    }
                    catch (Exception outputFileCrateError)
                    {
                        MessageBox.Show("There was an error while attempting to create the STORESCU Log file! \r\n" +
                                   $"Error: {outputFileCrateError.Message} \r\n\r\n" + "Please check that you're able to write to folder where this exe lives, and try again.",
                                   "ERROR: Unable to crate STORESCU Log file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // we'll check if the storescu send to target was successful or not
                    if (sb2.ToString().Contains("D: DIMSE Status                  : 0x0000: Success"))
                    {
                        pictureBox7.Visible = true;
                        label17.Text = $"Successfully Sent {patientName} to {GlobalVars.targetHostIPAfterTest}!";
                    }
                    else
                    {
                        MessageBox.Show($"There was an error while attempting to send the study the target ({GlobalVars.targetHostIPAfterTest}! \r\n" +
                                    "Please check logs to view full details.",
                                    $"ERROR: STORESCU - Unable to send to target ({GlobalVars.targetHostIPAfterTest}) ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (!saveDCMFilesLocallyCheckBox.Checked)
                    {
                        // we'll clear the recently downloaded folder
                        if (Directory.Exists(saveDCMFolder))
                        {
                            Directory.Delete(saveDCMFolder, true);
                        }
                    }
                }

            }

            searchResultsProgress.Visible = false;
            metroGrid1.Enabled = true;
            searchCAMMSelect.Enabled = true;
            searchMRNtxtbox.Enabled = true;
            searchACCtxtbox.Enabled = true;
            materialFlatButton2.Enabled = true;
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(GlobalVars.storeSCULog);
        }

        private void materialFlatButton5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(GlobalVars.moveSCULog); 
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (Directory.Exists(GlobalVars.downloadedDicomDataLocation))
            //{
            //    Directory.Delete(GlobalVars.downloadedDicomDataLocation, true);
            //}

            try
            {
                foreach (var process in Process.GetProcessesByName("notepad")) //whatever you need to close 
                {
                    if (process.MainWindowTitle.Contains("moveSCULog.txt"))
                    {
                        process.Kill();
                    }

                    if (process.MainWindowTitle.Contains("searchAccessionResults.txt"))
                    {
                        process.Kill();
                    }

                    if (process.MainWindowTitle.Contains("searchMRNResults.txt"))
                    {
                        process.Kill();
                    }

                    if (process.MainWindowTitle.Contains("storeSCPLog.txt"))
                    {
                        process.Kill();
                    }

                    if (process.MainWindowTitle.Contains("storeSCULog.txt"))
                    {
                        process.Kill();
                    }
                }

                if (Directory.Exists(GlobalVars.logDirectoryPath))
                {
                    Directory.Delete(GlobalVars.logDirectoryPath, true);
                }

            }
            catch (Exception)
            {


            }
        }

        private void saveDCMFilesLocallyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (saveDCMFilesLocallyCheckBox.Checked)
            {
                MessageBox.Show($"When set, a local copy of the study you send to the target will be stored in: \r\n ({GlobalVars.downloadedDicomDataLocation}! \r\n\r\n" +
                                    "Upon closing this utility, the files will be deleted automatically!",
                                    $"WARNING: Saving Local DCM Copies", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

}
