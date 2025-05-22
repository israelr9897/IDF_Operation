namespace IDF_Operation.Models
{
    static class SortTerroist
    {
        static internal List<Dictionary<Terrorist, int>> SortedNumberReports()
        {
            List<Dictionary<Terrorist, int>> SortedNumberReportsList = new List<Dictionary<Terrorist, int>>();
            for (int i = AuxiliaryFunTerr.MaxNumberReports(); i > 0; i--)
            {
                foreach (var key in AuxiliaryFunTerr.InitDict())
                {
                    if (key.Value == i)
                    {
                        SortedNumberReportsList.Add(new Dictionary<Terrorist, int> { { key.Key, i } });
                    }
                }
            }
            return SortedNumberReportsList;
        }
        internal static List<Terrorist> SortingByRisk(List<Terrorist> ansorted)
        {
            return ansorted.OrderBy(terroist => terroist.LevelRisk).ToList();
        }
    }
}