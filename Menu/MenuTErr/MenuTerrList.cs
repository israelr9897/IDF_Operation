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
            System.Console.WriteLine($"\n\nPlease select the desired option -\n" +
                                    "--------------\n" +
                                    "1.  Sort \n" +
                                    "2.  Search terrorist by ID\n" +
                                    "9.  Return to the back menu.\n" +
                                    "99. To Exit\n" +
                                    "--------------\n");
            UserChoiceCheck.UserChoice(ChoiceDict);
        }
        static void SearchTerr()
        {
            System.Console.WriteLine("\n\nPlease enter the terrorist's ID ");
            int Id = int.Parse(Console.ReadLine());
            SearchTerroist.SearchTerroistById(Id).Print();
            SubMenu.MiniReportMenuPrint();
        }
    }
}