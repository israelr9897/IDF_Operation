namespace IDF_Operation.Models
{
    static class SortReport
    {

        static public void SortReportsByDate()
        {

            foreach (var report in Aman.ReportList.OrderBy(report => report.TimeStamp).ToList())
            {
                report.Print();
            }
        }
    }
}