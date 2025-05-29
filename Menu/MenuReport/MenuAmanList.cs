namespace IDF_Operation.Models
{
    internal static class MenuAmanList
    {
        static Dictionary<int, Action[]> AmanListDict = new Dictionary<int, Action[]>
        {
            {1, new Action[] {SortReport.SortReportsByDate().Print, SubMenu.MiniTerrMenuPrint} },
            {2, new Action[] {SearchById, SubMenu.MiniTerrMenuPrint} },
            {9, new Action[] {Menu.MenuPrint} },
        };

        static public void MenuPrint()
        {
            System.Console.WriteLine($"Please select the desired option -\n" +
                                    "--------------\n" +
                                    "1.  Sort by Date \n" +
                                    "2.  Search for a report by ID\n" +
                                    "9.  Return to the back menu.\n" +
                                    "99. To Exit" +
                                    "--------------\n");
            UserChoiceCheck.UserChoice(AmanListDict);
        }

        // static public void UserChoice()
        // {
        //     int Choice = int.Parse(Console.ReadLine());
        //     if (Choice == 99)
        //     {
        //         Environment.Exit(0);
        //     }
        //     if (ChoiceDict.TryGetValue(Choice, out Action[] action))
        //     {
        //         foreach (var item in action)
        //         {
        //             item();
        //         }
        //     }
        //     else
        //     {
        //         System.Console.WriteLine("Invalid selection");
        //         MenuPrint();
        //     }
        // }

        static public void SearchById()
        {
            System.Console.WriteLine("Please enter the ID ");
            int id = int.Parse(Console.ReadLine());
            SearchReports.SearchReportById(id).Print();
        }
    }
}