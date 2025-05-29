using IDF_Operation.Models;

namespace IDF_Operation.Models
{
    static internal class Idf
    {
        public static string DateOfEstablishment = "01/05/1948";
        public static string CurrentCommander = "Eyal Zamir";
        public static List<StrikeOptions> StrikeOptionsList = new List<StrikeOptions>();
        public static List<AttackLog> AttackLogList = new List<AttackLog>();
        static public int Length() { return AttackLogList.Count(); }


    }
    
}