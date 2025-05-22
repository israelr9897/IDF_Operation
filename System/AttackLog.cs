using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_Operation.Models;

namespace IDF_Operation.Models
{
    internal class AttackLog
    {
        public static DateTime AttackTime = DateTime.Today;
        public static Terrorist Target;
        public static StrikeOptions StrikeOpUsed;
        public static String WeaponUsed;
        public static int FuelInUse;
        public static String CommandingOfficer;

        public AttackLog(
            Terrorist target, 
            StrikeOptions StrikeOp , 
            String Weapon , 
            int Fuel, 
            String officer)
        {
            Target = target;
            StrikeOpUsed = StrikeOp;
            WeaponUsed = Weapon;
            FuelInUse = Fuel;
            CommandingOfficer = officer;
        }
    }
    //new AttackLog(target, intel, strikeOp, weapon, FuelInUse);
}
