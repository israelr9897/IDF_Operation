namespace IDF_Operation.Models
{
    static class SortReport
    {
        static public List<IntelReport> SortReportsByDate(List<IntelReport> unSorted)
        {
            return unSorted.OrderByDescending(report => report.TimeStamp).ToList();
        }
    }
}