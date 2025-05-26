using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_Operation.Models;


namespace IDF_Operation.Models
{
    internal class StrikeOpsOverview
    {
        public static string AmmutType(StrikeOptions Type, string location)
        {
            string ammuType = "";
            if (Type.Name == "F16")
            {
                System.Console.WriteLine(Type.DictPrint());
                System.Console.WriteLine("Enter the ammunition type 1 or 0.5");
                ammuType = Console.ReadLine();

            }
            else if (Type.Name == "Zik 460")
            {
                if (location == "outside")
                {
                    ammuType = "personnel";
                }
                else
                {
                    ammuType = "armored vehicles";
                }
            }
            else
            {
                ammuType = "shell";
            }
            return ammuType;
        }
    }
}
