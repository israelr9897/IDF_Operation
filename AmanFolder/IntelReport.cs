
namespace IDF_Operation.Models
{
    internal class IntelReport
    {
        public Terrorist NameTerroist;
        public string Location;
        public string TimeStamp;

        public IntelReport(Terrorist nameTerroist, string location, string timeStamp)
        {
            this.NameTerroist = nameTerroist;
            this.Location = location;
            this.TimeStamp = timeStamp;
        }

    }
}