using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
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

            // the below wil invoke the material design
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            // now we'll set the version that'll display on the main screen
            labelVersion.Text = AppVersion;

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
            pictureBox8.Visible = false;
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
            if (sourceTransferSyntax.selectedIndex < 0)
            {
                MessageBox.Show("Please select a transfer syntax first. ", "Error: Verify Transfer Syntax", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sourceTransferSyntax.Focus();
                return;
            }

            var transferSyntax = "";
            var transferSyntaxValue = "";
            if (sourceTransferSyntax.selectedIndex == 0)
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
                        Arguments = $"-v -pts {_transferSyntax} {_hostname} {_port} -aec {_aet} -aet CERNERCMOVE",
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
            if (targetTransferSyntax1.selectedIndex < 0)
            {
                MessageBox.Show("Please select a transfer syntax first. ", "Error: Verify Transfer Syntax", MessageBoxButtons.OK, MessageBoxIcon.Error);
                targetTransferSyntax1.Focus();
                return;
            }

            if (sourceTransferSyntax.selectedIndex == 0)
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

            metroGrid1.Rows.Clear();
            pictureBox7.Visible = false;
            label17.Visible = false;
            pictureBoxSearchFailed.Visible = false;
            label18.Visible = false;

            searchResultsProgress.Visible = true;
            var patientFindResults = "";
            var accessionFindResults = "";

            if (!string.IsNullOrWhiteSpace(searchACCtxtbox.Text))
            {
                GlobalVars.searchAccStringValue = searchACCtxtbox.Text;

                await Task.Run(() =>
                {
                    accessionFindResults = (FindAccessionNumber(GlobalVars.searchHostIPValue, GlobalVars.searchAETValue,
                      GlobalVars.searchPortValue, GlobalVars.searchAccStringValue, "CERNERCMOVE"));
                });

                if ((accessionFindResults.Contains("I: Received Final Find Response (Success)") && ((accessionFindResults.Contains("I: (0008,0050) SH ["))) && ((accessionFindResults.Contains("I: (0020,000d) UI ["))) ))
                {
                    GlobalVars.AccessionFindResultsSuccess = true;

                    pictureBox7.Visible = true;
                    label17.Visible = true;
                    label17.Text = $"[SUCCESS] Accession {GlobalVars.searchAccStringValue} FOUND!";

                    List<string> newRow = new List<string>();
                    using (StringReader reader = new StringReader(accessionFindResults))
                    {
                        string line = string.Empty;
                        do
                        {
                            line = reader.ReadLine();
                            if (line != null)
                            {
                                if (line.Contains("I: (0010,0010) PN"))
                                {
                                    string outputNamepre = line.Substring(line.IndexOf('[') + 1);
                                    string outputNamepost = outputNamepre.Remove(outputNamepre.IndexOf("]") - 1); ;
                                    string outputNameremoveCarrot = outputNamepost.Replace("^", ",");
                                    newRow.Add(outputNameremoveCarrot);
                                }
                                else if (line.Contains($"I: (0010,0020) LO [")) 
                                {
                                    string outputMRNpre = line.Substring(line.IndexOf('[') + 1);
                                    string outputMRNpost = outputMRNpre.Remove(outputMRNpre.IndexOf("]") - 1); ;
                                    newRow.Add(outputMRNpost);
                                }
                                else if (line.Contains($"I: (0008,0050) SH ["))
                                {
                                    string outputAccessionpre = line.Substring(line.IndexOf('[') + 1);
                                    string outputAccessionpost = outputAccessionpre.Remove(outputAccessionpre.IndexOf("]") - 1); ;
                                    newRow.Add(outputAccessionpost);
                                }
                                else if (line.Contains($"I: (0020,000d) UI ["))
                                {
                                    string outputSUIDpre = line.Substring(line.IndexOf('[') + 1);
                                    string outputSUIDpost = outputSUIDpre.Remove(outputSUIDpre.IndexOf("]") - 1); ;
                                    newRow.Add(outputSUIDpost);
                                }
                            }

                        } while (line != null);

                    }

                    metroGrid1.Rows.Add(newRow[2], newRow[3], newRow[1], newRow[4]);

                    searchResultsProgress.Visible = false;
                }
                else
                {
                    GlobalVars.PatientFindResultsSuccess = false;
                    searchResultsProgress.Visible = false;
                    pictureBoxSearchFailed.Visible = true;
                    label18.Visible = true;
                    label18.Text = $"[FAILURE] Unable to Query/Find Accession {GlobalVars.searchAccStringValue}";

                }

            }
            else
            {
                GlobalVars.searchMRNStringValue = searchMRNtxtbox.Text;
                await Task.Run(() =>
                {
                    patientFindResults = (FindPatID(GlobalVars.searchHostIPValue, GlobalVars.searchAETValue,
                      GlobalVars.searchPortValue, GlobalVars.searchMRNStringValue, "CERNERCMOVE"));
                });

                if ((patientFindResults.Contains("Received Final Find Response (Success)") && ((patientFindResults.Contains("I: (0010,0010) PN [")) || patientFindResults.Contains($"I: (0010,0020) LO [{GlobalVars.searchMRNStringValue} ]"))))
                {
                    GlobalVars.PatientFindResultsSuccess = true;

                    pictureBox7.Visible = true;
                    label17.Visible = true;
                    label17.Text = $"[SUCCESS] PATIENT ID {GlobalVars.searchMRNStringValue} FOUND!";

                    List<string> newRow = new List<string>();
                    using (StringReader reader = new StringReader(patientFindResults))
                    {
                        string line = string.Empty;
                        do
                        {
                            line = reader.ReadLine();
                            if (line != null)
                            {
                                if (line.Contains("I: (0010,0010) PN"))
                                {
                                    string outputPNpre = line.Substring(line.IndexOf('[') + 1);
                                    string outputPNpost = outputPNpre.Remove(outputPNpre.IndexOf("]") - 1); ;
                                    string outputPNremoveCarrot = outputPNpost.Replace("^", ",");
                                    newRow.Add(outputPNremoveCarrot);
                                }
                                else if (line.Contains($"I: (0010,0020) LO [{GlobalVars.searchMRNStringValue} ]"))
                                {
                                    string outputMRNpre = line.Substring(line.IndexOf('[') + 1);
                                    string outputMRNpost = outputMRNpre.Remove(outputMRNpre.IndexOf("]") - 1); ;
                                    newRow.Add(outputMRNpost);
                                }
                            }

                        } while (line != null);

                    }

                    metroGrid1.Rows.Add(newRow[0], newRow[1]);

                    searchResultsProgress.Visible = false;
                }
                else
                {
                    GlobalVars.PatientFindResultsSuccess = false;
                    searchResultsProgress.Visible = false;
                    pictureBoxSearchFailed.Visible = true;
                    label18.Visible = true;
                    label18.Text = $"[FAILURE] Unable to Query/Find PATIENT ID {GlobalVars.searchMRNStringValue}";

                }
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
                var FindAccessionNumber = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = $"{Application.StartupPath}\\findscu.exe",
                        //Arguments = $"-v {_hostname} {_port} -aec {_aet} -aet MoveAET",
                        //Arguments = $"-v {_hostname} {_port} -aec {_aet} -aet CERNMIGECHO",
                        //Arguments = $"-v -P -xi -d -k 0008,0052=PATIENT -k 0010,0020=\"{PatID}\" {CAMMHostname} {CAMMPort} -aec {CAMMAET} -aet {CallingAET}",
                        Arguments = $"-v -P -{trSynToUse} -k 0008,0052=PATIENT -k 0010,0020=\"{PatID}\" {CAMMHostname} {CAMMPort} -aec {CAMMAET} -aet {CallingAET}",
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
                        Arguments = $"-v -P -{trSynToUse} -k 0008,0052=STUDY -k 0008,0050=\"{AccessionNumber}\" {CAMMHostname} {CAMMPort} -aec {CAMMAET} -aet {CallingAET}",
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

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            pictureBox8.Visible = false;
            label19.Visible = false;

            //if (metroGrid1.SelectedRows.Count > 0)
            //{
            //    pictureBox8.Visible = true;
            //    label19.Visible = true;

            //    //check which fields are available based on the search to show the user
            //    if (!string.IsNullOrWhiteSpace(GlobalVars.searchAccStringValue))
            //    {
            //        var dataFields = metroGrid1.SelectedRows.
            //    }

            //    if (MessageBox.Show($"Are you sure you want to Migrate data between the two below listed PACS systems? \r\n\r\n" +
            //                        $"Source AET: {GlobalVars.SourceAETAfterTest} \r\n" +
            //                        $"Source Hostname: {GlobalVars.SourceHostIPAfterTest} \r\n\r\n" +
            //                        $"Target AET: {GlobalVars.targetAETAfterTest} \r\n" +
            //                        $"Data: {GlobalVars.targetHostIPAfterTest}\r\n" +
            //                        $"Target Hostname: {GlobalVars.targetHostIPAfterTest}\r\n", "Question: Confirm DICOM Data Migration", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            //    {
            //        //textBoxActions.AppendText($"     UPDATE: User elected not to begin DICOM Migration. \n\n");
            //        return;
            //    }


            //}

        }

    }
}
