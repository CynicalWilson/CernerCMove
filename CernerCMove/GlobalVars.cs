using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CernerCMove
{
    class GlobalVars
    {
        // this var is for the the folder path where CDU.exe is runnig in
        public static string ApplicationStartPath = Application.StartupPath;

        // the below vars are used for testing and setting vars for echo and modalites
        public static bool SourceAETCechoSuccess = false;
        public static bool TargetAETCechoSuccess = false;
        public static string SourceAETAfterTest = "";
        public static string SourceHostIPAfterTest = "";
        public static string SourcePortAfterTest = "";
        public static string targetAETAfterTest = "";
        public static string targetHostIPAfterTest = "";
        public static string targetPortAfterTest = "";
        public static string TransferSyntax = "";
        public static string TransferSyntaxValue = "";

        // this var will be search value the user entered for the cfind
        public static string searchAccStringValue = "";
        public static string searchMRNStringValue = "";
        public static string searchHostIPValue = "";
        public static string searchAETValue = "";
        public static string searchPortValue = "";
        public static bool PatientFindResultsSuccess = false;
        public static bool AccessionFindResultsSuccess = false;
        public static string FindMRNFailure = "";
        public static string FindAccessionNumberFailure = "";

        // these vars are for the MWL search results 
        public static bool mwlSearchResultsResults = false;

        // this var will be set for the utility's AET to be used else in the utility 
        public static string UtilityAET = "";

        // this var will be used for the location of the logfile
        public static string connectLogFile = ApplicationStartPath + @"\Logs\connectLog.txt";

        // this var will be used for the location of the MRN search results
        public static string searchMRNResults = ApplicationStartPath + @"\Logs\searchMRNResults.txt";

        // this var will be used for the location of the MRN search results to confirm if the selected study is or isn't in the target SCP
        // if it is, then we'll WARN the user of the possible overwrite and re-announce!
        public static string searchMRNInTargetResults = ApplicationStartPath + @"\Logs\searchMRNInTargetResults.txt";

        // this var will be file that'll hold the image serach for the View Image Details UC
        public static string searchSOPInfoFromSUIDResults = ApplicationStartPath + @"\Logs\searchSOPInfoFromSUIDResults.txt";

        // this var will be used for the location of the Accession search results
        public static string searchAccessionResults = ApplicationStartPath + @"\Logs\searchAccessionResults.txt";
        
        // this var will be used for the location of the migration error results 
        public static string migrationErrorLogLocation = ApplicationStartPath + @"\Logs\migrationErrorLog.txt";

        // this var will be used for the location of the storeSCU log results 
        public static string storeSCPLog = ApplicationStartPath + @"\Logs\storeSCPLog.txt";

        // this var will be used for the location of the moveSCU results 
        public static string moveSCULog = ApplicationStartPath + @"\Logs\moveSCULog.txt";

        // this var will be used for the location of the storeSCU results 
        public static string storeSCULog = ApplicationStartPath + @"\Logs\storeSCULog.txt";

        // this var will be used for the location of the download DICOM Studies 
        public static string downloadedDicomDataLocation = ApplicationStartPath + @"\Downloads\";

        // this var will be used for the location of the root Logs directory
        public static string logDirectoryPath = ApplicationStartPath + @"\Logs\";

        // this var will be used for the location of the MWL search results
        public static string mwlSearchResultsLog = ApplicationStartPath + @"\Logs\mwlSearchResultsLog.txt";

        // this var will allow the user to save the sop UID's with or without the prefix 
        public static bool addPreFixSOPUIDs = false;

        // this will have tell the send button that we're only going to download the study rather than download and sending it to the target
        public static bool saveDCMButtonClicked = false;

        // this will set true or false if the user wants to anonymize the study upon download
        public static bool anonymizeStudy = false;

        // this will set true or false if the user wants to anonymize the study upon download
        public static bool zipStudyAfterDownload = false;

        // this is the log file for anonymizing the study
        public static string anonymizeStudyLog = ApplicationStartPath + @"\Logs\anonymizeStudyLog.txt";

        // we'll set the var for which level study or series the user is going to use for the c-find
        public static string searchCfindLevel = "";

        // we'll set the var for which level study or series the user is going to use for the c-find - it's flag
        public static string searchCfindLevelFlag = "";

        // we'll set the int var for the row index when the user right-clicks a row on the search datagrid
        public static string userSelectedSUIDRowValue = "";

        // we'll set the int var for the row index when the user right-clicks a row on the search datagrid
        public static string userSelectedPatientNameRowValue = "";

        // we'll set the int var for the row index when the user right-clicks a row on the search datagrid
        public static string userSelectedAccRowValue = "";

        // we'll set the int var for the row index when the user right-clicks a row on the search datagrid
        public static string userSelectedMRNRowValue = "";

        // this var will be full path of the SOP UID row that the user selected from the VIew Image Details UC
        public static string downloadedStudyFolder = "";

        // this var will be full path of the SOP UID row that the user selected from the VIew Image Details UC
        public static string downloadedStudyFolderWithSOP = "";

        // this var is the location of the DICOM header dump text file
        public static string SOPDicomHeaderDumpFile = ApplicationStartPath + @"\Logs\SOPDicomHeaderDumpFile.txt";

        // this var is the location of the DICOM header dump log actions file
        public static string SOPDicomHeaderDumpLogFile = ApplicationStartPath + @"\Logs\SOPDicomHeaderDumpLogFile.txt";

        // this method will be callsed on the main form file to make sure the exe root folder 
        // has a Logs folder, and if not, it'll create it. 
        public static void CreateLogDirectory()
        {
            //var logDirectoryPath = ApplicationStartPath + @"\Logs";
            if (!Directory.Exists(logDirectoryPath))
            {
                Directory.CreateDirectory(logDirectoryPath);
            }

            if (!Directory.Exists(downloadedDicomDataLocation))
            {
                Directory.CreateDirectory(downloadedDicomDataLocation);
            }
        }
    }
}
