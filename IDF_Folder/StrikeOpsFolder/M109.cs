using IDF_Operation.Models;


namespace IDF_Operation.Models
{
    internal class M109 : StrikeOptions
    {
        public M109(int fuelSupply) : base(
                "M109",
                Idf.StrikeOptionsList.Count +1,
                fuelSupply,
                "outside")
        { }
        
        public override Dictionary<string, int> AmmunitionRefill()
        {
            return new Dictionary<string, int>
                {
                    { "shell", 40 }
                };
        }
    }
}