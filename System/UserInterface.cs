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


        public void AttackCase(Terrorist target, StrikeOptions strikeOp, string ammuType,string officer, IntelReport report)
        {
            Random random = new Random();
            int FuelInUse = random.Next(5, 20);
            AttackExe.Attack(target, strikeOp, ammuType, FuelInUse);
            ListOfAttacks.list.Add(new AttackLog(ListOfAttacks.Length()+1, target, strikeOp, ammuType, FuelInUse, officer, report));
        }

       

        //public string StrickOpsCase(StrikeOptions StrickOp)
        //{
        //    return "";
        //}

    }
}
