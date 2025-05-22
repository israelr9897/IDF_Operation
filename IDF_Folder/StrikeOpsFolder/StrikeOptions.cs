using IDF_Operation.Models;
namespace IDF_Operation.Models
{
    public abstract class StrikeOptions : IFuelAndAmmunition
    {
        public string Name { get; }
        public int Id { get; }
        public Dictionary<string, int> AmmunitionAmount;
        public int FuelSupply { get; set; }
        public string TargetType { get; }

        public StrikeOptions(string name, int id, int fuelSupply, string targetType)
        {
            Name = name;
            Id = id;
            AmmunitionAmount = AmmunitionRefill();
            FuelSupply = fuelSupply;
            TargetType = targetType;
        }

        public void FuelFilling(int fuelAmount)
        {
            FuelSupply = fuelAmount;
        }
        public void FuelUsing(int amountFuel)
        {
            FuelSupply -= amountFuel;
        }
        public void AmmunitionUsing(string ammunitionType)
        {
            AmmunitionAmount[ammunitionType] -= 1;
        }
        public abstract Dictionary<string, int> AmmunitionRefill();

        public void DataPrinting()
        {
            System.Console.WriteLine($"ID: {Id}\n" +
                                    $"Type of attack vehicle - {Name}\n" +
                                    $"Amount of ammunition -{DictPrint()}\n" +
                                    $"Amount of fuel - {FuelSupply}\n" +
                                    $"Type of targets - {TargetType}");
        }

        public string DictPrint()
        {
            string amount = "";
            foreach (var item in AmmunitionAmount)
            {
                amount += item.Key + " : " + item.Value + "     ";
            }
            return amount;
        }

        public static void SearchWeapon(int id)
        {
            foreach (var weapon in Idf.StrikeOptionsList)
            {
                if (weapon.Id == id)
                {
                    weapon.DataPrinting();
                }
            }
        }

    }
}