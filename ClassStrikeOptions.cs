namespace IDF_Operation
{
    internal class StrikeOptions
    {
        public string Name { get; }
        public Dictionary<string, int> AmmunitionAmount { get; }
        public int FuelSupply { get; }
        public string TargetType { get; }

        public StrikeOptions(string name, Dictionary<string, int> ammunitionAmount, int fuelSupply, string targetType)
        {
            this.Name = name;
            this.AmmunitionAmount = ammunitionAmount;
            this.FuelSupply = fuelSupply;
            this.TargetType = targetType;
        }

    }
}