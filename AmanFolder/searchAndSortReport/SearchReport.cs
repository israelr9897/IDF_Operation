namespace IDF_Operation.Models
{
    static class SearchReports
    {
        internal static IntelReport SearchReportByTerroist(int terroistId)
        {
            foreach (var report in Aman.ReportList)
            {
                if (report.TerroristName.Id == terroistId)
                {
                    return report;
                }
            }
            return null;
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