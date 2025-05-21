
using System.Xml.Linq;

namespace IDF_Operation.Models
{
    internal class IntelReport
    {
        public Terrorist TerroristName;
        public string Location;
        public DateTime TimeStamp;

        public IntelReport(Terrorist nameTerrorist, string location, DateTime timeStamp)
        {
            this.TerroristName = nameTerrorist;
            this.Location = location;
            this.TimeStamp = timeStamp;
        }
        public void Print()
        {
            //string weaponsSTR = String.Join(",", Weapons);
            Console.WriteLine($"IntelReport,\nTerrorist Name: {TerroristName.Name},\nLocation: {Location},\nTimeStamp: {TimeStamp.ToString("yyyy-MM-ddTHH:mm:ss")}.\n");
        }

    }
}