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
        private void AttackCase(StrikeOptions strikeOp, string ammuType,string officer, IntelReport intel)
        {
            Random random = new Random();
            int FuelInUse = random.Next(5, 20);
            AttackExe.Attack(intel.TerroristName, strikeOp, ammuType, FuelInUse);
            ListOfAttacks.list.Add(new AttackLog(ListOfAttacks.Length(), intel.TerroristName, strikeOp, ammuType, FuelInUse, officer, intel));
    }
    }
}
