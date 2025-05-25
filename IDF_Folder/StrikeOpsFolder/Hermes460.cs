using IDF_Operation.Models;


namespace IDF_Operation.Models
{
    internal class Zik : StrikeOptions
    {
        public Zik(int fuelSupply) : base(
                "Zik 460",
                Idf.StrikeOptionsList.Count +1,
                fuelSupply,
                "people, vehicles")
        { }

        public override Dictionary<string, int> AmmunitionRefill()
        {
            return new Dictionary<string, int>
                {
                    { "personnel", 1 },
                    { "armored vehicles", 2 }
                };
        }
    }
}