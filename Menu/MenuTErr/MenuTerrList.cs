namespace IDF_Operation.Models
{
    internal static class MenuTerrList
    {
        static Dictionary<int, Action[]> ChoiceDict = new Dictionary<int, Action[]>
        {
            {1, new Action[]{MenuTerrSort.MenuPrint} },
            {2, new Action[]{SearchTerr} },
            {9, new Action[]{MenuTerroists.MenuPrint} }
        };


        static public void MenuPrint()
        {
            System.Console.WriteLine($"Please select the desired option -\n" +
                                    "1.  Sort \n" +
                                    "2.  Search terrorist by ID\n" +
                                    "9.  Return to the back menu.\n" +
                                    "99. To Exit");
            UserChoiceCheck.UserChoice(ChoiceDict);
        }

        // static public void UserChoice()
        // {
        //     int Choice = int.Parse(Console.ReadLine());
        //     if (Choice == 99)
        //     {
        //         Environment.Exit(0);
        //     }
        //     if (ChoiceDict.TryGetValue(Choice, out Action action))
        //     {
        //         action();
        //     }
        // }

        static void SearchTerr()
        {
            System.Console.WriteLine("Please enter the terrorist's ID ");
            int Id = int.Parse(Console.ReadLine());
            SearchTerroist.SearchTerroistById(Id).Print();
            SubMenu.MiniReportMenuPrint();
        }
    }
}