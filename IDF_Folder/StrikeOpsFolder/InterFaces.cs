using IDF_Operation.Models;
namespace IDF_Operation.Models
{
    interface IFuelAndAmmunition
    {
        void FuelFilling(StrikeOptions obj,int fuelAmount);
        void FuelUsing(StrikeOptions obj, int ammountFuel);
        void AmmunitionUsing(StrikeOptions obj, string ammunitionType);
        abstract Dictionary<string, int> AmmunitionRefill();
    }
}