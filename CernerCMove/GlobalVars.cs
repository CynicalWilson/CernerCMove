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

        // this var will be used for the location of the logfile
        public static string connectLogFile = ApplicationStartPath + @"\Logs\connectLog.txt";

        // this var will be used for the location of the MRN search results
        public static string searchMRNResults = ApplicationStartPath + @"\Logs\searchMRNResults.txt";

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
