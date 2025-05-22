namespace IDF_Operation.Models
{
    static class SearchTerroist
    {
        public static void SearchTerroistById(int id)
        {
            foreach (var terroist in Hamas.Terrorists)
            {
                if (terroist.Id == id)
                {
                    terroist.Print();
                }
            }
        }

        public static void SearchTerrMostDanger()
        {
            foreach (var terroist in Hamas.Terrorists)
            {
                if (terroist.LevelRisk == AuxiliaryFunTerr.SearchMaxLevelRisk())
                {
                    terroist.Print();
                    System.Console.WriteLine("The level of danger is: " + terroist.LevelRisk);

                }
            }
        }

        public static void SearchTerrMostReports()
        {
            int mustReport = AuxiliaryFunTerr.MaxNumberReports();
            foreach (var key in AuxiliaryFunTerr.InitDict())
            {
                if (key.Value == mustReport)
                {
                    key.Key.Print();
                    System.Console.WriteLine("Number of reports found: " + mustReport);
                }
            }
        }
    }
}