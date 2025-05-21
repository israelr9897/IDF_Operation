namespace IDF_Operation
{
    internal class F16 : StrikeOptions
    {
        public string PilotName { get; }
        public F16(
            string name,
            Dictionary<string, int> ammunitionAmount,
            int fuelSupply,
            string typeTarget,
            string pilotName) : base(
                "F16",
                new Dictionary<string, int>
                {
                    { "1", 4 },
                    { "0.5", 4 }
                },
                fuelSupply,
                "Buildings")
        {
            this.PilotName = pilotName;
        }
    }
    internal class Zik : StrikeOptions
    {
        public Zik(
            string name,
            Dictionary<string, int> ammunitionAmount,
            int fuelSupply,
            string typeTarget) : base(
                "Zik 460",
                new Dictionary<string, int>
                {
                    { "personnel", 1 },
                    { "armored vehicles", 2 }
                },
                fuelSupply,
                "people, vehicles")
        { }
    }
    internal class M109 : StrikeOptions
    {
        public M109(
            string name,
            Dictionary<string, int> ammunitionAmount,
            int fuelSupply,
            string typeTarget) : base(
                "M109",
                new Dictionary<string, int>
                {
                    { "shell", 40 }
                },
                fuelSupply,
                "open areas")
        { }
    }
}