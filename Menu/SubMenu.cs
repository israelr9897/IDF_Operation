namespace IDF_Operation.Models
{
    static class SubMenu
    {
        static int ReportId;
        static int TerrId;

        static Dictionary<int, Action[]> MiniReportChoiceDict = new Dictionary<int, Action[]>
        {
            {1, new Action[]{ChoiceTerroist, ViweReports, MiniTerrMenuPrint}},
            {100, new Action[]{ChoiceReport, StartAttack}},
            {9, new Action[] {MenuTerroists.MenuPrint}},
        };
        static Dictionary<int, Action[]> MiniTerrChoiceDict = new Dictionary<int, Action[]>
        {
            {1, new Action[]{ChoiceReport, ViweTerroist, MiniReportMenuPrint}},
            {100, new Action[]{ChoiceReport, StartAttack}},
            { 9, new Action[] {MenuAmanList.MenuPrint}},
        };

        static public void MiniReportMenuPrint()
        {
            System.Console.WriteLine($"\n\nPlease select the desired option -\n" +
                                    "--------------\n" +
                                    "1.   To view the terrorist reports\n" +
                                    "9.   Return to the main menu.\n" +
                                    "100. To carry out an attack\n" +
                                    "99.  Exit\n" +
                                    "--------------\n");
            UserChoiceCheck.UserChoice(MiniReportChoiceDict);
        }
        static public void MiniTerrMenuPrint()
        {
            System.Console.WriteLine($"\n\nPlease select the desired option -\n" +
                                    "--------------\n" +
                                    "1.  To view the terrorist in the report\n" +
                                    "9.  Return to the main menu.\n" +
                                    "99. Exit\n" +
                                    "--------------\n");
            UserChoiceCheck.UserChoice(MiniTerrChoiceDict);
        }

        static internal void ViweReports()
        {
            SearchReports.SearchReportByTerroist(TerrId).Print();
        }
        static internal void ViweTerroist()
        {
            IntelReport report = SearchReports.SearchReportById(ReportId);
            SearchTerroist.SearchTerroistById(report.TerroristName.Id).Print();
        }

        static void ChoiceTerroist()
        {
            System.Console.WriteLine("\n\nEnter terroist's the Id");
            TerrId = int.Parse(Console.ReadLine());
        }
        static public void ChoiceReport()
        {
            System.Console.WriteLine("\n\nEnter report's the Id");
            ReportId = int.Parse(Console.ReadLine());
        }

        static public void StartAttack()
        {
            IntelReport report = SearchReports.SearchReportById(ReportId);
            if (CheckIsAlive(report))
            {
                MenuAttack.StartAttack(report);
            }
            else
            {
                System.Console.WriteLine("\n\nThe terrorist you selected is dead!!\n" +
                                        "Please enter a report of another terrorist.");
                MiniReportMenuPrint();

            }
        }

        private static bool CheckIsAlive(IntelReport report)
        {
            return report.TerroristName.Status == "alive";
        }
    }
}