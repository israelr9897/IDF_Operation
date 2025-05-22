using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_Operation.Models;

namespace IDF_Operation.Models
{
    internal class AttackExe
    {
        private static Random random = new Random();
        public static int FuelInUse = random.Next(5, 20);

        public void Attack(Terrorist target,StrikeOptions strikeOp, string ammuType, int FuelInUse)
        {
            strikeOp.FuelUsing(FuelInUse);
            strikeOp.AmmunitionUsing(ammuType);
            target.Killed();
        }

    }
}
