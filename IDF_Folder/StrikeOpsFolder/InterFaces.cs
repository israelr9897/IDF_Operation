using IDF_Operation.Models;
namespace IDF_Operation.Models
{
    interface IFuelAndAmmunition
    {
        void FuelFilling(int fuelAmount);
        void FuelUsing(int ammountFuel);
        void AmmunitionUsing(string ammunitionType);
        abstract Dictionary<string, int> AmmunitionRefill();
    }
}