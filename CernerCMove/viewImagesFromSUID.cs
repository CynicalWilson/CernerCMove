using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using CernerCMove;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace HyperionDCM
{
    partial class viewImagesFromSUID : MaterialForm
    {
        public viewImagesFromSUID()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            pictureBox7.Visible = false;
            label17.Visible = false;
            pictureBox10.Visible = false;
            label19.Visible = false;
            ViewImageDetailsProgressBar.Visible = false;

            // we'll set the header read-only textboxes to show the below info
            imageViewMRN.Text = GlobalVars.userSelectedMRNRowValue;
            imageViewPatientName.Text = GlobalVars.userSelectedPatientNameRowValue;
            imageViewStudyUID.Text = GlobalVars.userSelectedSUIDRowValue;

            // now we'll get the image SOP ID info and show it in the datagrid
            StringBuilder sb5 = new StringBuilder();
            var trSynToUse = "";

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
                ViewImageDetailsProgressBar.Visible = true;
                pictureBox10.Visible = true;
                label19.Visible = true;
                label19.Text = "Loading Image SOP Details...";

                var getImageDetailsFromSUID = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = $"{Application.StartupPath}\\findscu.exe",
                        //Arguments = $"-v {_hostname} {_port} -aec {_aet} -aet MoveAET",
                        //Arguments = $"-v {_hostname} {_port} -aec {_aet} -aet CERNMIGECHO",
                        //Arguments = $"-v -P -xi -d -k 0008,0052=PATIENT -k 0010,0020=\"{PatID}\" {CAMMHostname} {CAMMPort} -aec {CAMMAET} -aet {CallingAET}",
                        Arguments = $"-d -S -{trSynToUse} -k 0008,0052=IMAGE -k 0020,000d=\"{GlobalVars.userSelectedSUIDRowValue}\" -k 0010,0010 -k 0010,0021 -k 0008,0050 -k 0008,1030 -k 0008,0061 -k 0008,0060 -k 0008,0020 {GlobalVars.SourceHostIPAfterTest} {GlobalVars.SourcePortAfterTest} -aec {GlobalVars.SourceAETAfterTest} -aet {GlobalVars.UtilityAET}",
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true
                    }
                };

                getImageDetailsFromSUID.Start();

                while (!getImageDetailsFromSUID.StandardOutput.EndOfStream)
                {

                    //var line = SourceAETCEcho.StandardOutput.ReadLine();

                    sb5.AppendLine("    " + getImageDetailsFromSUID.StandardOutput.ReadLine());
                    //sb.AppendLine("\r\n");

                    //cechoAETResponse.Add(line + "\r\n");
                    //textBoxActions.AppendText(line + "\r\n");

                }

                getImageDetailsFromSUID.WaitForExit();

            }
            catch (Exception e1)
            {
                MessageBox.Show("There was an error while attempting to fetch the image SOP data for the SUID, from the Source SCP. \r\n" +
                            $"Error: {e1.Message} \r\n\r\n" + "Please review the log for more details.",
                            "ERROR: Unable to fetch the image SOP data for the SUID, from the Source SCP", MessageBoxButtons.OK, MessageBoxIcon.Error);

                pictureBox10.Visible = false;
                label19.Visible = false;
                ViewImageDetailsProgressBar.Visible = false;

            }

            // we'll save the output to the log file
            try
            {
                File.Delete(GlobalVars.searchSOPInfoFromSUIDResults);
                File.WriteAllLines(GlobalVars.searchSOPInfoFromSUIDResults, new[] { sb5.ToString() });
            }
            catch (Exception outputFileCrateError)
            {

                MessageBox.Show("There was an error while attempting to create the verify selected row in Target output file! \r\n" +
                            $"Error: {outputFileCrateError.Message} \r\n\r\n" + "Please check that you're able to write to folder where this exe lives, and try again.",
                            "ERROR: Unable to crate selected row in Target output file", MessageBoxButtons.OK, MessageBoxIcon.Error);

                pictureBox10.Visible = false;
                label19.Visible = false;
                ViewImageDetailsProgressBar.Visible = false;
            }

            // now that we've queries the target pacs for the study the user is about to send, we'll check if it 
            // exist in the target, and if it does, we'll WARN the user of the possible re-write and re-announce!

            var afterSBTrim = sb5.ToString().Replace("\0", "");

            if ((afterSBTrim.ToString().Contains(GlobalVars.userSelectedSUIDRowValue)))
            {
                List<string> studySOPList = new List<string>();

                using (StringReader reader = new StringReader(afterSBTrim))
                {
                    string line = string.Empty;
                    var outputSOPUIDpost = "";
                    var outputAApost = "";
                    var outputSeriesUIDpost = "";
                    var outputModalityTypepost = "";
                    do
                    {
                        line = reader.ReadLine();
                        if (line != null)
                        {
                            // based on the level of search the user has selected we'll choose one of the below values
                            // the user can select from PATIENT, STUDY, and SERIES
                            // check if tag is present based on c-find level 

                            // setting values to N/A for those that are not present 
                            if (!afterSBTrim.Contains("D: (0008,0018) UI [")) //
                            {
                                outputSOPUIDpost = "N/A";
                            }
                            if (!afterSBTrim.Contains("D: (0020,000e) UI [")) //
                            {
                                outputSeriesUIDpost = "N/A";
                            }
                            if (!afterSBTrim.Contains("D: (0008,0060) CS [")) // 
                            {
                                outputModalityTypepost = "N/A";
                            }
                            if (!afterSBTrim.Contains("D: (0010,0021) LO [")) //
                            {
                                outputAApost = "N/A";
                            }

                            // checking actual values
                            if ((line.Contains("D: (0010,0021) LO [")))
                            {
                                string outputAApre = line.Substring(line.IndexOf('[') + 1);
                                outputAApost = outputAApre.Remove(outputAApre.IndexOf("]")); ;
                            }
                            else if (line.Contains("D: (0010,0021) LO ("))
                            {
                                outputAApost = "N/A";
                                continue;
                            }
                            if (line.Contains("D: (0008,0060) CS ["))
                            {
                                string outputModalityTypepre = line.Substring(line.IndexOf('[') + 1);
                                outputModalityTypepost = outputModalityTypepre.Remove(outputModalityTypepre.IndexOf("]"));

                            }
                            else if (line.Contains("D: (0008,0060) CS ("))
                            {
                                outputModalityTypepost = "N/A";
                                continue;

                            }
                            if (line.Contains("D: (0008,0018) UI ["))
                            {
                                string outputSOPUIDpre = line.Substring(line.IndexOf('[') + 1);
                                outputSOPUIDpost = outputSOPUIDpre.Remove(outputSOPUIDpre.IndexOf("]"));

                                studySOPList.Add(outputSOPUIDpost);
                            }
                            else if (line.Contains("D: (0008,0018) UI ("))
                            {
                                outputSOPUIDpost = "N/A";
                                continue;
                            }
                            if (line.Contains("D: (0020,000e) UI ["))
                            {
                                string outputSeriesUIDpre = line.Substring(line.IndexOf('[') + 1);
                                outputSeriesUIDpost = outputSeriesUIDpre.Remove(outputSeriesUIDpre.IndexOf("]"));
                            }
                            else if (line.Contains("D: (0020,000e) UI ("))
                            {
                                outputSeriesUIDpost = "N/A";
                                continue;
                            }

                            if ((!string.IsNullOrEmpty(outputSOPUIDpost))
                                  && (!string.IsNullOrEmpty(outputAApost))
                                  && (!string.IsNullOrEmpty(outputSeriesUIDpost))
                                  && (!string.IsNullOrEmpty(outputModalityTypepost)))
                            {
                                metroGrid1.Rows.Add(outputModalityTypepost, outputSOPUIDpost, outputSeriesUIDpost, outputAApost);
                                outputSOPUIDpost = "";
                                outputAApost = "";
                                outputSeriesUIDpost = "";
                                outputModalityTypepost = "";
                            }
                        }

                    } while (line != null);
                }

                // we'll check if the current study SUID is in the suid list
                // if it is, then we'll skip; we're doing this because the c-find
                // we're using is doing it at the series level so you'll see an entry
                // of the study SUID in the datagrid multiple times 
                for (int i = 0; i < metroGrid1.Rows.Count; i++)
                {
                    var studySUIDCheck = metroGrid1.Rows[i].Cells[1].Value.ToString();

                    //bool isRepeated = studySUIDsList.Count(x => x == studySUIDCheck) != 1;

                    var count = studySOPList.Where(x => x.Equals(studySUIDCheck)).Count();

                    if (count > 1)
                    {
                        metroGrid1.Rows.Remove(metroGrid1.Rows[i]);
                        studySOPList.Remove(studySUIDCheck);
                    }

                }
                for (int i = 0; i < metroGrid1.Rows.Count; i++)
                {
                    var studySUIDCheck = metroGrid1.Rows[i].Cells[1].Value.ToString();

                    //bool isRepeated = studySUIDsList.Count(x => x == studySUIDCheck) != 1;

                    var count = studySOPList.Where(x => x.Equals(studySUIDCheck)).Count();

                    if (count > 1)
                    {
                        metroGrid1.Rows.Remove(metroGrid1.Rows[i]);
                        studySOPList.Remove(studySUIDCheck);
                    }

                }
                for (int i = 0; i < metroGrid1.Rows.Count; i++)
                {
                    var studySUIDCheck = metroGrid1.Rows[i].Cells[1].Value.ToString();

                    //bool isRepeated = studySUIDsList.Count(x => x == studySUIDCheck) != 1;

                    var count = studySOPList.Where(x => x.Equals(studySUIDCheck)).Count();

                    if (count > 1)
                    {
                        metroGrid1.Rows.Remove(metroGrid1.Rows[i]);
                        studySOPList.Remove(studySUIDCheck);
                    }

                }
            }


            pictureBox10.Visible = false;
            label19.Visible = false;
            pictureBox7.Visible = true;
            label17.Visible = true;
            ViewImageDetailsProgressBar.Visible = false;
            label17.Text = "[SUCCESS] Finished Loading Image SOP Details for Selected Study.";


            //this.Text = String.Format($"[Image Details] MRN: {CernerCMove.GlobalVars.userSelectedMRNRowValue} | {CernerCMove.GlobalVars.userSelectedPatientNameRowValue} \r\n" +
            //    $"Accession#: {CernerCMove.GlobalVars.userSelectedAccRowValue} | SUID: {CernerCMove.GlobalVars.userSelectedSUIDRowValue}");
            //this.labelProductName.Text = AssemblyProduct;
            //this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            //this.labelCopyright.Text = AssemblyCopyright;
            //this.labelCompanyName.Text = AssemblyCompany;
            //this.textBoxDescription.Text = AssemblyDescription;
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void metroGrid1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //ContextMenu m = new ContextMenu();
                //m.MenuItems.Add(new MenuItem("Cut"));
                //m.MenuItems.Add(new MenuItem("Copy"));
                //m.MenuItems.Add(new MenuItem("Paste"));

                int currentMouseOverRow = metroGrid1.HitTest(e.X, e.Y).RowIndex;
                materialContextMenuStrip1.Items[0].Enabled = false;

                if (currentMouseOverRow >= 0)
                {
                    metroGrid1.Rows[currentMouseOverRow].Selected = true;

                    var SOPUID = metroGrid1.Rows[currentMouseOverRow].Cells[1].Value.ToString();

                    if (SOPUID != "N/A")
                    {
                        //var studySUIDValue = metroGrid1.Rows[currentMouseOverRow].Cells[6].Value.ToString();
                        GlobalVars.downloadedStudyFolderWithSOP = GlobalVars.downloadedStudyFolder.Trim() + "\\" +SOPUID;
                        materialContextMenuStrip1.Items[0].Enabled = true;
                    }
                    else
                    {
                        materialContextMenuStrip1.Items[0].Enabled = false;
                    }

                    materialContextMenuStrip1.Show(metroGrid1, new Point(e.X, e.Y));
                }

            }
        }

        private async void viewDICOMHeaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ViewImageDetailsProgressBar.Visible = true;
                pictureBox10.Visible = true;
                label19.Visible = true;
                label19.Text = "Processing DICOM Header Export on Selected SOP UID...";
                StringBuilder sb6 = new StringBuilder();

                // we'll delete the existing dump text file
                if (File.Exists(GlobalVars.SOPDicomHeaderDumpFile))
                {
                    File.Delete(GlobalVars.SOPDicomHeaderDumpFile);
                }

                await Task.Run(() =>
                {
                    var SOPHeaderDump = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = $"{Application.StartupPath}\\dcmdump.exe",
                            //Arguments = $"-v {_hostname} {_port} -aec {_aet} -aet MoveAET",
                            //Arguments = $"-v {_hostname} {_port} -aec {_aet} -aet CERNMIGECHO",
                            //Arguments = $"-v -P -xi -d -k 0008,0052=PATIENT -k 0010,0020=\"{PatID}\" {CAMMHostname} {CAMMPort} -aec {CAMMAET} -aet {CallingAET}",
                            //Arguments = $"-v -P -xi -k 0008,0052=STUDY -k 0008,0050=\"{AccessionNumber}\" {CAMMHostname} {CAMMPort} -aec {CAMMAET} -aet {CallingAET}",
                            //Arguments = $"-v -P -xi -k 0008,0052=STUDY -k 0010,0010=\"{PatientName}\" -k 0008,00020 -k 0008,0030 -k 0008,0050 -k 0008,0061 -k 0008,0080 -k 0008,1030 -k 0008,0090 {CAMMHostname} {CAMMPort} -aec {CAMMAET} -aet {CallingAET}",
                            Arguments = $"-d \"{GlobalVars.downloadedStudyFolderWithSOP}\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        }
                    };

                    SOPHeaderDump.Start();

                    while (!SOPHeaderDump.StandardOutput.EndOfStream)
                    {

                        //var line = SourceAETCEcho.StandardOutput.ReadLine();


                        sb6.AppendLine("    " + SOPHeaderDump.StandardOutput.ReadLine());

                        //sb.AppendLine("\r\n");

                        //cechoAETResponse.Add(line + "\r\n");
                        //textBoxActions.AppendText(line + "\r\n");

                    }

                    SOPHeaderDump.WaitForExit();

                    // we'll write the sb var to the log 
                    try
                    {
                        //File.Delete(GlobalVars.searchAccessionResults);
                        File.Delete(GlobalVars.SOPDicomHeaderDumpLogFile);
                        File.AppendAllLines(GlobalVars.SOPDicomHeaderDumpLogFile, new[] {
                                        "---------------\r\n" + DateTime.Now.ToString() + "| DCMDUMP PROCESS START \r\n"+
                                        sb6.ToString() + "\r\n" + "---------------\r\n\r\n" });
                    }
                    catch (Exception outputFileCrateError)
                    {

                        MessageBox.Show("There was an error while attempting to create the SOP Header Dump Log file! \r\n" +
                                    $"Error: {outputFileCrateError.Message} \r\n\r\n" + "Please check that you're able to write to folder where this exe lives, and try again.",
                                    "ERROR: Unable to crate the SOP Header Dump Log file", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        ViewImageDetailsProgressBar.Visible = false;
                    }

                    //if (!sb.ToString().Contains("error"))
                    //{
                    //    GlobalVars.UpdateNewDCMFileSuccess = true;
                    //}
                    //else
                    //{
                    //    GlobalVars.UpdateNewDCMFileSuccess = false;
                    //}
                });

                ViewImageDetailsProgressBar.Visible = false;
                pictureBox10.Visible = false;
                label19.Visible = false;
                pictureBox7.Visible = true;
                label17.Visible = true;
                label17.Text = "[SUCCESS] DICOM Header Export Complete.";

                // now we'll open the header dump file for the user
                if (File.Exists(GlobalVars.SOPDicomHeaderDumpLogFile))
                {
                    System.Diagnostics.Process.Start(GlobalVars.SOPDicomHeaderDumpLogFile);
                }
            }
            catch (Exception SOPHeaderDump)
            {

                ViewImageDetailsProgressBar.Visible = false;
                pictureBox10.Visible = false;
                label19.Visible = false;
                pictureBox7.Visible = false;
                label17.Visible = true;
                label17.Text = "Failed to anonymize the study! Please see log file for details.";

                MessageBox.Show("There was an error while attempting to export DICOM Header! \r\n" +
                             $"Error: {SOPHeaderDump.Message} \r\n\r\n" + "Please check that you're able to write to folder where this files lives, and try again.",
                             "ERROR: Unable to export DICOM Header!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
