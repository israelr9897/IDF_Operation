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
        public void FuelUsing(int ammountFuel)
        {
            FuelSupply -= ammountFuel;
        }
        public void AmmunitionUsing(string ammunitionType)
        {
            AmmunitionAmount[ammunitionType] -= 1;
        }
        public abstract Dictionary<string, int> AmmunitionRefill();

        public void DataPriting()
        {
            System.Console.WriteLine($"ID: {Id}\n" +
                                    $"Type of attack vehicle - {Name}\n" +
                                    $"Amount of ammunition -{DictPrint()}\n" +
                                    $"Amount of fuel - {FuelSupply}\n" +
                                    $"Type of targets - {TargetType}");
        }

        public string DictPrint()
        {
            string messge = "";
            foreach (var item in AmmunitionAmount)
            {
                messge += item.Key + " : " + item.Value + "     ";
            }
            return messge;
        }

    }
}