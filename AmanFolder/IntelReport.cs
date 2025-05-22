
using System.Xml.Linq;

namespace IDF_Operation.Models
{
    internal class IntelReport
    {
        public int Id;
        public Terrorist TerroristName;
        public string Location;
        public DateTime TimeStamp;

        public IntelReport(int id, Terrorist nameTerrorist, string location, DateTime timeStamp)
        {
            this.Id = id;
            this.TerroristName = nameTerrorist;
            this.Location = location;
            this.TimeStamp = timeStamp;
        }
        public void Print()
        {
            //string weaponsSTR = String.Join(",", Weapons);
            Console.WriteLine($"Report Id: {Id}\nTerrorist Name: {TerroristName.Name},\nLocation: {Location},\nTimeStamp: {TimeStamp.ToString("yyyy-MM-ddTHH:mm:ss")}.\n");
        }

    }
}