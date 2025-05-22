using IDF_Operation.Models;

namespace IDF_Operation
{
    class Program
    {
        static void Main(string[] args)
        {
            // InitTerrorists t = new InitTerrorists(5);
            // InitReports v = new InitReports(5);
            // Aman.ReportPrint();
            // Aman.SortedNumberReports();
            // Aman.InitDict();
            InitWeapons s = new InitWeapons(2);
            Idf.StrikeOptionsListPrint();
        }
    }

}