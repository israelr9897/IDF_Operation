using IDF_Operation.Models;
namespace IDF_Operation.Models
{
    internal class StrikeOptions : IFuelAndAmmunition
    {
        public string Name { get; }
        public Dictionary<string, int> AmmunitionAmount;
        public int FuelSupply { get; set; }
        public string TargetType { get; }

        public StrikeOptions(string name, Dictionary<string, int> ammunitionAmount, int fuelSupply, string targetType)
        {
            Name = name;
            AmmunitionAmount = ammunitionAmount;
            FuelSupply = fuelSupply;
            TargetType = targetType;
        }

        public void FuelFilling(StrikeOptions obj)
        {
            obj.FuelSupply = 100;
        }
        public void FuelUsing(StrikeOptions obj, int ammountFuel)
        {
            obj.FuelSupply -= ammountFuel;
        }
        public static void AmmunitionRefill(StrikeOptions obj, string ammunitionType)
        {
            
            switch (obj.Name)
            {
                case "F16":
                    obj.AmmunitionAmount = new Dictionary<string, int>
                    {
                        { "1", 4 },
                        { "0.5", 4 }
                    };
                    break;

                case "armored vehicles":
                    obj.AmmunitionAmount = new Dictionary<string, int>
                    {
                        { "personnel", 1 },
                        { "armored vehicles", 2 }
                    };
                    break;

                case "M109":
                    obj.AmmunitionAmount = new Dictionary<string, int>
                    {
                        { "shell", 40 }
                    };
                    break;
            }
        }
        public void AmmunitionUsing(StrikeOptions obj, string ammunitionType)
        {
            obj.AmmunitionAmount[ammunitionType] -= 1;
        }

        private static int AmmunitionSorting(string ammunitionType)
        {
            return -1;
        }

    }
}