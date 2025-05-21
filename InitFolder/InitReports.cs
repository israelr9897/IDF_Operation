using IDF_Operation.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace IDF_Operation.Models
{
    internal class InitReports
    {
        public static string[] LocationTypes = { "home", "car", "outside" };
        private Random random = new Random();


        public InitReports()
        {
            foreach (Terrorist t in Hamas.Terrorists)
            {
                int amountReports = random.Next(10);
                for (int i = 0; i < amountReports; i++)
                {
                    Aman.ReportList.Add(new IntelReport(
                        t, 
                        LocationTypes[random.Next(4)], 
                        GenerateTimestamp()));
                }

            }

        }

        private DateTime GenerateTimestamp()
        {
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            //DateTime timestamp = start.AddDays(random.Next(range));
            return start.AddDays(random.Next(range)).AddHours(random.Next(0, 24)).AddMinutes(random.Next(0, 60)).AddSeconds(random.Next(0, 60));
        }
    }
}
