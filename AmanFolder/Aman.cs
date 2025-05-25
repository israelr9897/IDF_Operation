using IDF_Operation.Models;
namespace IDF_Operation.Models
{
    static internal class Aman
    {
        static public List<IntelReport> ReportList = new List<IntelReport>();
      
        static internal List<Dictionary<Terrorist, int>> SortedNumberReports()
        {
            List<Dictionary<Terrorist, int>> SortedNumberReportsList = new List<Dictionary<Terrorist, int>>();
            for (int i = MaxNumberReports(); i > 0; i--)
            {
                foreach (var key in InitDict())
                {
                    if (key.Value == i)
                    {
                        SortedNumberReportsList.Add(new Dictionary<Terrorist, int> { { key.Key, i } });
                    }
                }
            }
            return SortedNumberReportsList;
        }
        static private int MaxNumberReports()
        {
            int maxReport = 0;
            foreach (var report in InitDict())
            {
                if (report.Value > maxReport)
                {
                    maxReport = report.Value;
                }
            }
            return maxReport;
        }

        static private Dictionary<Terrorist, int> InitDict()
        {
            Dictionary<Terrorist, int> reportAmout = new Dictionary<Terrorist, int>();
            foreach (var report in Aman.ReportList)
            {
                if (reportAmout.ContainsKey(report.TerroristName))
                {
                    reportAmout[report.TerroristName] += 1;
                }
                else
                {
                    reportAmout[report.TerroristName] = 1;
                }
            }
            return reportAmout;
        }

        internal static List<Terrorist> SortingByRisk(List<Terrorist> ansorted)
        {
            return ansorted.OrderBy(terroist => terroist.LevelRisk).ToList();
        }

        internal static List<IntelReport> SearchReportByTerroist(int id)
        {
            List<IntelReport> reportLoistByTerroist = new List<IntelReport>();
            foreach (var report in Aman.ReportList)
            {
                if (report.TerroristName.Id == id)
                {
                    reportLoistByTerroist.Add(report);
                }
            }
            return reportLoistByTerroist;
        }
        
        static public List<IntelReport> SortReportsByDate(List<IntelReport> UnSorted)
        {
            return UnSorted.OrderBy(report => report.TimeStamp).ToList();
        }

    }
}