using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_Operation.Models;

namespace IDF_Operation.Models
{
    static internal class AttackExe
    {
        public static void Attack(Terrorist target,StrikeOptions strikeOp, string ammuType, int FuelInUse)
        {
            strikeOp.FuelUsing(FuelInUse);
            strikeOp.AmmunitionUsing(ammuType);
            target.Killed();
        }

    }
}
