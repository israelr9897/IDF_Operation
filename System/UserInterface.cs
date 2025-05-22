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


        private void AttackCase(Terrorist target, StrikeOptions strikeOp, string ammuType,string officer)
        {
            Random random = new Random();
            int FuelInUse = random.Next(5, 20);
            AttackExe.Attack(target, strikeOp, ammuType, FuelInUse);
            ListOfAttacks.list.Add(new AttackLog(ListOfAttacks.Length(), target, strikeOp, ammuType, FuelInUse, officer));
    }
    }
}
