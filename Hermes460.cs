namespace IDF_Operation
{
    class Zik : StrikeOptions
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
}