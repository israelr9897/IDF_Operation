namespace IDF_Operation.Models
{
    static class MenuTerrSort
    {
        static Dictionary<int, Action[]> ChoiceDict = new Dictionary<int, Action[]>
        {
            {1, new Action[] {SortTerroist.SortingByRisk().Print, SubMenu.MiniReportMenuPrint} },
            {2, new Action[] {SortTerroist.SortedNumberReports().Print, SubMenu.MiniReportMenuPrint} },
            {9, new Action[] {MenuPrint} },
        };

        static public void MenuPrint()
        {
            System.Console.WriteLine($"Please select the desired option -\n" +
                                    "1.  Sort by risk\n" +
                                    "2.  Sort by most reports \n" +
                                    "9. Return to the back menu.\n" +
                                    "99. To Exit");
            UserChoice();
        }


        static public void UserChoice()
        {
            int choice = int.Parse(Console.ReadLine());
            if (choice == 99)
            {
                Environment.Exit(0);
            }
            if (ChoiceDict.TryGetValue(choice, out Action[] action))
            {
                foreach (var item in action)
                {
                    item();
                }
            }
        }
    }
}