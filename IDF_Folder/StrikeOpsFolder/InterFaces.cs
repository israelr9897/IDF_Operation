using IDF_Operation.Models;
namespace IDF_Operation.Models
{
    interface IFuelAndAmmunition
    {
        void FuelFilling(StrikeOptions obj);
        void FuelUsing(StrikeOptions obj, int ammountFuel);
        void AmmunitionRefill(StrikeOptions obj, string ammunitionType);
        void AmmunitionUsing(StrikeOptions obj, string ammunitionType);
    }
}