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
        public int LogID;
        public DateTime AttackTime = DateTime.Today;
        public Terrorist Target;
        public StrikeOptions StrikeOpUsed;
        public string WeaponUsed;
        public int FuelInUse;
        public string CommandingOfficer;
        public int IntelReportID;

        public AttackLog(
            int id,
            Terrorist target,
            StrikeOptions StrikeOp,
            string Weapon,
            int Fuel,
            string officer,
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

        // internal void Printer()
        // {
        //     Console.WriteLine("\n\nAttack Report -\n" +
        //         "--------------\n" +
        //         $"ID: {LogID},\n" +
        //         $"Target: {Target.Name},\n" +
        //         $"Time: {AttackTime}\n" +
        //         $"Attack Commander: {CommandingOfficer}\n" +
        //         $"StrikeOpUsed: {StrikeOpUsed.Name}\n" +
        //         $"WeaponUsed: {WeaponUsed}\n" +
        //         $"Fuel Used: {FuelInUse}\n" +
        //         $"Attack was based on intel report ID: {IntelReportID}\n" +
        //         "--------------\n");
        // }

        // internal static void Print(List<AttackLog> list)
        // {
        //     foreach (var AttackLog in list)
        //     {
        //         AttackLog.Printer();
        //     }
        // }
    }
}
