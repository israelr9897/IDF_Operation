using IDF_Operation.Models;

namespace IDF_Operation.Models
{
    static internal class Idf
    {
        public static string DateOfEstablishment = "01/05/1948";
        public static string CurrentCommander = "Eyal Zamir";
        public static List<StrikeOptions> StrikeOptionsList = new List<StrikeOptions>();

        static internal void  StrikeOptionsListPrint()
        {
            foreach (var weaopn in StrikeOptionsList)
            {
                weaopn.DataPrinting();
                System.Console.WriteLine("\n\n");
            }
        }
    }
    
}