namespace IDF_Operation.Models
{
    static class SubMenu
    {
        static int ReportId;
        static int TerrId;

        static Dictionary<int, Action[]> MiniReportChoiceDict = new Dictionary<int, Action[]>
        {
            {1, new Action[]{ChoiceTerroist, ViweReports, MiniReportMenuPrint}},
            {9, new Action[] {MenuTerroists.MenuPrint}},
        };
        static Dictionary<int, Action[]> MiniTerrChoiceDict = new Dictionary<int, Action[]>
        {
            {1, new Action[]{ChoiceReport, ViweTerroist, MiniReportMenuPrint}},
            {9, new Action[] {MenuAmanList.MenuPrint}},
        };

        static public void MiniReportMenuPrint()
        {
            System.Console.WriteLine($"Please select the desired option -\n" +
                                    "1.  To view the terrorist reports\n" +
                                    "9.  Return to the main menu.\n" +
                                    "99. Exit");
            UserChoiceCheck.UserChoice(MiniReportChoiceDict);
        }
        static public void MiniTerrMenuPrint()
        {
            System.Console.WriteLine($"Please select the desired option -\n" +
                                    "1.  To view the terrorist in the report\n" +
                                    "9.  Return to the main menu.\n" +
                                    "99. Exit");
            UserChoiceCheck.UserChoice(MiniTerrChoiceDict);
        }

        static internal void ViweReports()
        {
            SearchReports.SearchReportByTerroist(ReportId).Print();
        }
        static internal void ViweTerroist()
        {
            IntelReport report = SearchReports.SearchReportById(TerrId);
            SearchTerroist.SearchTerroistById(report.TerroristName.Id).Print();
        }

        static void ChoiceTerroist()
        {
            System.Console.WriteLine("Enter terroist's the Id");
            ReportId = int.Parse(Console.ReadLine());
        }
        static void ChoiceReport()
        {
            System.Console.WriteLine("Enter report's the Id");
            TerrId = int.Parse(Console.ReadLine());
        }
    }
}