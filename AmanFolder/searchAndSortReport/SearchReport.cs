namespace IDF_Operation.Models
{
    static class SearchTerrMostReports
    {
        internal static void SearchReportByTerroist(int terroistId)
        {
            foreach (var report in Aman.ReportList)
            {
                if (report.TerroristName.Id == terroistId)
                {
                    report.Print();
                }
            }
        }

        internal static void SearchReportById(int reportId)
        {
            foreach (var report in Aman.ReportList)
            {
                if (report.Id == reportId)
                {
                    report.Print();
                }
            }
        }
    }
}