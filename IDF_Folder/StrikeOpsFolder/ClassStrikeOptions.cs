namespace IDF_Operation.IDF_Folder.StrikeOpsFolder.strike_ops
{
    internal class StrikeOptions
    {
        public string Name { get; }
        public Dictionary<string, int> AmmunitionAmount { get; }
        public int FuelSupply { get; }
        public string TargetType { get; }

        public StrikeOptions(string name, Dictionary<string, int> ammunitionAmount, int fuelSupply, string targetType)
        {
            Name = name;
            AmmunitionAmount = ammunitionAmount;
            FuelSupply = fuelSupply;
            TargetType = targetType;
        }

    }
}