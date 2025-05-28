using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_Operation.Models;


namespace IDF_Operation.Models
{
    internal class UserInterface
    {
        internal static void AttackCase(string officer, IntelReport intel)
        {
            Random random = new Random();
            int FuelInUse = random.Next(5, 20);
            StrikeOptions strikeOp = StrikeOpsOverview.StrickOpsCase(intel.Location);
            string ammuType = StrikeOpsOverview.AmmoCase(strikeOp, intel.Location);
            AttackExe.Attack(intel.TerroristName, strikeOp, ammuType, FuelInUse);
            AttackLog atteckReport = new AttackLog(ListOfAttacks.Length()+1, intel.TerroristName, strikeOp, ammuType, FuelInUse, officer, intel);
            atteckReport.Printer();
            ListOfAttacks.list.Add(atteckReport);
    }
    }
}
