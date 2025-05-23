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
        }
    }
}