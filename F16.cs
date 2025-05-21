namespace IDF_Operation
{
    class F16 : StrikeOptions
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
}