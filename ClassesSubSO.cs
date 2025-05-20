namespace IDF_Operation
{
    internal class F16 : StrikeOptions
    {
        public F16(string name, Dictionary<string, int> ammunitionAmount, int fuelSupply, string typeTarget) : base("F16", new Dictionary<string, int> { {"1", 4}, {"0.5", 4}}, 100, "Buildings"){}
    }
    internal class Zik : StrikeOptions
    {
        public Zik(string name, Dictionary<string, int> ammunitionAmount, int fuelSupply, string typeTarget) : base("Zik", new Dictionary<string, int> { {"1", 4}, {"0.5", 4}}, 100, "Buildings"){}
    }
    internal class M109 : StrikeOptions
    {
        public M109(string name, Dictionary<string, int> ammunitionAmount, int fuelSupply, string typeTarget) : base("M109", new Dictionary<string, int> { {"1", 4}, {"0.5", 4}}, 100, "Buildings"){}
    }
}