namespace IDF_Operation.Models
{
    static class SubMenu
    {
        static int Id;
        static Dictionary<int, Action[]> MiniChoiceDict = new Dictionary<int, Action[]>
        {
            {1, new Action[]{ChoiceTerroist, ViweReports, MiniMenuPrint}},
            {9, new Action[] {MenuTerroists.MenuPrint}},
        };

        static public void MiniMenuPrint()
        {
            System.Console.WriteLine($"Please select the desired option -\n" +
                                    "1.  To view the terrorist reports\n" +
                                    "9.  Return to the main menu.\n" +
                                    "99. Exit");
            MenuTerroists.UserChoice(MiniChoiceDict);
        }

        static internal void ViweReports()
        {
            SearchReports.SearchReportByTerroist(Id).Print();
        }

        static void ChoiceTerroist()
        {
            System.Console.WriteLine("Enter terroist's the Id");
            Id = int.Parse(Console.ReadLine());
        }
    }
}