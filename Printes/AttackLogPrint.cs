namespace IDF_Operation.Models
{
    static public class AttackPrint
    {
        internal static void Print(this AttackLog obj)
        {
            Console.WriteLine("\n\nAttack Report -\n" +
                "--------------\n" +
                $"ID: {obj.LogID},\n" +
                $"Target: {obj.Target.Name},\n" +
                $"Time: {obj.AttackTime}\n" +
                $"Attack Commander: {obj.CommandingOfficer}\n" +
                $"StrikeOpUsed: {obj.StrikeOpUsed.Name}\n" +
                $"WeaponUsed: {obj.WeaponUsed}\n" +
                $"Fuel Used: {obj.FuelInUse}\n" +
                $"Attack was based on intel report ID: {obj.IntelReportID}\n" +
                "--------------\n");
        }
        internal static void Print(this List<AttackLog> list)
        {
            foreach (var attackLog in list)
            {
                attackLog.Print();
            }
        }
    }
}