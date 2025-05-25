using System.Security.Cryptography.X509Certificates;

namespace IDF_Operation.Models
{
    static class SearchTerroist 
    {
        public static Terrorist SearchTerroistById(int id)
        {
            foreach (var terroist in Hamas.Terrorists)
            {
                if (terroist.Id == id)
                {
                    return terroist;
                }
            }
            return null;
        }

        public static List<Terrorist> SearchTerrMostDanger()
        {
            List<Terrorist> DangerousTerr = new List<Terrorist>();
            foreach (var terroist in Hamas.Terrorists)
            {
                if (terroist.LevelRisk == AuxiliaryFunTerr.SearchMaxLevelRisk())
                {
                    DangerousTerr.Add(terroist);
                }
            }
            return DangerousTerr;
        }

        public static List<Terrorist> SearchTerrMostReports()
        {
            List<Terrorist> TerrMostReport = new List<Terrorist>();
            int mustReport = AuxiliaryFunTerr.MaxNumberReports();
            foreach (var key in AuxiliaryFunTerr.InitDict())
            {
                if (key.Value == mustReport)
                {
                    TerrMostReport.Add(key.Key);
                }
            }
            return TerrMostReport;
        }
    }
}