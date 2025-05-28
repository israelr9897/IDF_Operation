namespace IDF_Operation.Models
{
    static class SortReport
    {
        static public List<IntelReport> SortReportsByDate()
        {
            return Aman.ReportList.OrderByDescending(report => report.TimeStamp).ToList();
        }
    }
}