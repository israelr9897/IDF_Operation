using IDF_Operation.Models;
namespace IDF_Operation.Models
{
    static internal class Aman
    {
        static public List<IntelReport> ReportList = new List<IntelReport>();

        static public List<IntelReport> SortReportsByDate(List<IntelReport> UnSorted)
        {
            return UnSorted.OrderBy(report => report.TimeStamp).ToList();
        }
    }

    

}