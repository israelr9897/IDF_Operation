using IDF_Operation.Models;

namespace IDF_Operation.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            InitTerrorists t = new InitTerrorists(5);
            InitReports v = new InitReports(5);
            InitWeapons w = new InitWeapons(2);
            Idf.StrikeOptionsListPrint();
            StrikeOptions.SearchWeapon(1);
            // SortReport.SortReportsByDate();
            // Hamas.TerroristsListPrint();
            // System.Console.WriteLine("\n\n\n");
            // SearchTerroist.SearchTerroistById(2);
            // SearchTerroist.SearchTerrMostDanger();
            // SearchTerroist.SearchTerrMostReports();
            // MenuTerroists.UserChoice();
            // Aman.ReportListPrint();
            // System.Console.WriteLine(Hamas.Terrorists);
        }
    }
}
            // Aman.SortedNumberReports();
            // Aman.InitDict();
            // InitWeapons s = new InitWeapons(2);
            // Idf.StrikeOptionsListPrint();