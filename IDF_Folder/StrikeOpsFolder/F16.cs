using IDF_Operation.Models;

namespace IDF_Operation.Models
{
    internal class F16 : StrikeOptions
    {
        public string PilotName { get; }
        public F16(int fuelSupply,
            string pilotName) : base(
                "F16",
                Idf.StrikeOptionsList.Count +1,
                fuelSupply,
                "home")
        {
            PilotName = pilotName;
        }

        public override Dictionary<string, int> AmmunitionRefill()
        {
            return new Dictionary<string, int>
                {
                    { "0.5", 4 },
                    { "1", 4 }
                };
        }
    }
}