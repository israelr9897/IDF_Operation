namespace IDF_Operation.Models
{
    static class SearchReports
    {
        internal static List<IntelReport> SearchReportByTerroist(int terroistId)
        {
            List<IntelReport> reports = new List<IntelReport>();
            foreach (var report in Aman.ReportList)
            {
                if (report.TerroristName.Id == terroistId)
                {
                    reports.Add(report);
                }
            }
            return reports;
        }

        internal static IntelReport SearchReportById(int reportId)
        {
            foreach (var report in Aman.ReportList)
            {
                if (report.Id == reportId)
                {
                    return report;
                }
            }
            return null;
        }
    }
}