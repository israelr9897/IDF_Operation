namespace IDF_Operation.Models
{
    static class WeaponsPrint
    {
        public static void Print(this StrikeOptions obj)
        {
            System.Console.WriteLine($"ID: {obj.Id}\n" +
                                    $"Type of attack vehicle - {obj.Name}\n" +
                                    $"Amount of ammunition -{obj.DictPrint()}\n" +
                                    $"Amount of fuel - {obj.FuelSupply}\n" +
                                    $"Type of targets - {obj.TargetType}\n");
        }
        public static void Print(this List<StrikeOptions> list)
        {
            foreach (var weapon in list)
            {
                weapon.Print();
            }
        }

        internal static string DictPrint(this StrikeOptions obj)
        {
            string amount = "";
            foreach (var item in obj.AmmunitionAmount)
            {
                amount += item.Key + " : " + item.Value + "     ";
            }
            return amount;
        }

    }
}