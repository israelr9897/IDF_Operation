using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_Operation.Models;

namespace IDF_Operation.Models
{
    internal static class Hamas
    {
        public static string DateOfFormation = "1991";
        public static string Commander = "Mohammed Sinwar";
        public static List<Terrorist> Terrorists = new List<Terrorist>();


        public static void TerroristsListPrint()
        {
            foreach (var terroist in Terrorists)
            {
                terroist.Print();
            }
            // System.Console.WriteLine("YES");
        }
    }
}
