namespace IDF_Operation.Models
{
    static class MenuSearchTerr
    {
        static int Id;
        static bool Loop = true;
        static Dictionary<int, Action> ChoiceDict = new Dictionary<int, Action>
        {
            {1, ViweReports},
            {11, MenuTerrList.MenuPrint},
            {00, ToFalse}
        };

        static MenuSearchTerr()
        {
            System.Console.WriteLine("Please enter the terrorist's ID ");
            Id = int.Parse(Console.ReadLine());
            SearchTerroist.SearchTerroistById(Id).Print();
        }
        static public void MenuPrint()
        {
            System.Console.WriteLine($"Please select the desired option -\n" +
                                    "1. To view the terrorist reports\n" +
                                    "11. Return to the main menu.\n" +
                                    "00. Exit");
            UserChoice();   
        }
        static public void UserChoice()
        {
            int Choice = int.Parse(Console.ReadLine());
            if (ChoiceDict.TryGetValue(Choice, out Action action))
            {
                action();
                if (Loop)
                {
                    MenuTerroists.MenuPrint();
                }

            }

        }

        static void ViweReports()
        {
            SearchReports.SearchReportByTerroist(Id).Print();
            MenuTerrList.MenuPrint();
        }

        static private void ToFalse()
        {
            Loop = false;
        }
    }
}