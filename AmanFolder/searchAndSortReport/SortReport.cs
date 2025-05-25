namespace IDF_Operation.Models
{
    static class SortReport
    {
        static public List<IntelReport> SortReportsByDate()
        {
            return Aman.ReportList.OrderBy(report => report.TimeStamp).ToList();
        }
    }
}