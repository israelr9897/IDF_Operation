using IDF_Operation.Models;

namespace IDF_Operation.Models
{
    internal class F16 : StrikeOptions
    {
        public string PilotName { get; }
        public F16(
            "F16",
                StrikeOptions.AmmunitionRefill(name),
                fuelSupply,
                "Buildings",
            string pilotName) : base(
                "F16",
                StrikeOptions.AmmunitionRefill(name),
                fuelSupply,
                "Buildings")
        {
            PilotName = pilotName;
        }
    }
}