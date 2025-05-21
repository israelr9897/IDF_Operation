using IDF_Operation.Models;
namespace IDF_Operation.Models
{
    public abstract class StrikeOptions : IFuelAndAmmunition
    {
        public string Name { get; }
        public Dictionary<string, int> AmmunitionAmount;
        public int FuelSupply { get; set; }
        public string TargetType { get; }

        public StrikeOptions(string name, int fuelSupply, string targetType)
        {
            Name = name;
            AmmunitionAmount = AmmunitionRefill();
            FuelSupply = fuelSupply;
            TargetType = targetType;
        }

        public void FuelFilling(StrikeOptions obj,int fuelAmount)
        {
            obj.FuelSupply = fuelAmount;
        }
        public void FuelUsing(StrikeOptions obj, int ammountFuel)
        {
            obj.FuelSupply -= ammountFuel;
        }
        public void AmmunitionUsing(StrikeOptions obj, string ammunitionType)
        {
            obj.AmmunitionAmount[ammunitionType] -= 1;
        }
        public abstract Dictionary<string, int> AmmunitionRefill();

    }
}