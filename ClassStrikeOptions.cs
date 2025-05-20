namespace IDF_Operation
{
    internal class StrikeOptions
    {
        public string Name;
        public Dictionary<string, int> AmmunitionAmount;
        public int FuelSupply;
        public string TypeTarget;

        public StrikeOptions(string name, Dictionary<string, int> ammunitionAmount, int fuelSupply, string typeTarget)
        {
            this.Name = name;
            this.AmmunitionAmount = ammunitionAmount;
            this.FuelSupply = fuelSupply;
            this.TypeTarget = typeTarget;
        }

    }
}