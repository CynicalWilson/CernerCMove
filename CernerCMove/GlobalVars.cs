using System;
using System.Collections.Generic;
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

        // this var will be used for the location of the logfile
        public static string connectLogFile = ApplicationStartPath + @"\Logs\connectLog.txt";

        // this var will be used for the location of the MRN search results
        public static string searchMRNResults = ApplicationStartPath + @"\Logs\searchMRNResults.txt";

        // this var will be used for the location of the Accession search results
        public static string searchAccessionResults = ApplicationStartPath + @"\Logs\searchAccessionResults.txt";
    }
}
