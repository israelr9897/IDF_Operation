using IDF_Operation.terrorist;

namespace IDF_Operation
{
    internal class IntelReport
    {
        public Terrorist NameTerroist;
        public string Location;
        public string TimeStamp;

        internal IntelReport(Terrorist nameTerroist, string location, string timeStamp)
        {
            this.NameTerroist = nameTerroist;
            this.Location = location;
            this.TimeStamp = timeStamp;
        }

    }
}