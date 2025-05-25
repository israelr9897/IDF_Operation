namespace IDF_Operation.Models
{
    static class AuxiliaryFunTerr
    {
        static public int MaxNumberReports()
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

        static public Dictionary<Terrorist, int> InitDict()
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

        public static int SearchMaxLevelRisk()
        {
            int maxLevel = 0;
            foreach (var terroist in Hamas.Terrorists)
            {
                if (terroist.LevelRisk > maxLevel)
                {
                    maxLevel = terroist.LevelRisk;
                }
            }
            return maxLevel;
        }
    }
}