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
        public static int LogID;
        public static DateTime AttackTime = DateTime.Today;
        public static Terrorist Target;
        public static StrikeOptions StrikeOpUsed;
        public static String WeaponUsed;
        public static int FuelInUse;
        public static String CommandingOfficer;
        public static int IntelReportID;


        public AttackLog(
            int id,
            Terrorist target, 
            StrikeOptions StrikeOp , 
            String Weapon , 
            int Fuel, 
            String officer,
            IntelReport intel)
        {
            LogID = id;
            Target = target;
            StrikeOpUsed = StrikeOp;
            WeaponUsed = Weapon;
            FuelInUse = Fuel;
            CommandingOfficer = officer;
            IntelReportID = intel.Id;
        }

        internal void Printer()
        {
            Console.WriteLine($"ID: {LogID},\n" +
                $"Target: {Target.Name},\n" +
                $"Time: {AttackTime}\n" +
                $"Attack Commander: {CommandingOfficer}\n" +
                $"StrikeOpUsed: {StrikeOpUsed.Name}\n" +
                $"WeaponUsed: {WeaponUsed}\n" +
                $"Fuel Used: {FuelInUse}\n" +
                $"Attack was based on intel report ID: {IntelReportID}\n");
        }
    }
}
