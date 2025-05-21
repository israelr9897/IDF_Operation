using IDF_Operation.Models;
namespace IDF_Operation.Models
{
    interface IFuelAndAmmunition
    {
        void FuelFilling();
        void AmmunitionRefill();
        void AmmunitionShortage();
        void FuelShortage();
    }
}