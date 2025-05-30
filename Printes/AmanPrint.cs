namespace IDF_Operation.Models
{
    static class Printes
    {
        public static void Print(this IntelReport obj)
        {
            Console.WriteLine($"Report Id: {obj.Id}\nTerrorist Id:{obj.TerroristName.Id}\nName: {obj.TerroristName.Name},\nLocation: {obj.Location},\nTimeStamp: {obj.TimeStamp.ToString("yyyy-MM-ddTHH:mm:ss")}.\n");
        }
        public static void Print(this List<IntelReport> list)
        {
            foreach (var report in list)
            {
                report.Print();
            }
        }

    }
}