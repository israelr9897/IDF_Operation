namespace IDF_Operation.Models
{
    internal static class MenuTerrList 
    {
        static Dictionary<int, Action> ChoiceDict = new Dictionary<int, Action>
        {
            {1, MenuTerrSort.MenuPrint},
            {2, MenuSearchTerr.MenuPrint},
            {9,MenuTerroists.MenuPrint},
        };

        static public void MenuPrint()
        {
            System.Console.WriteLine($"Please select the desired option -\n" +
                                    "1.  Sort \n" +
                                    "2.  Search terrorist by ID\n" +
                                    "11. Return to the back menu.\n" +
                                    "00. To Exit");
            UserChoice();
        }

        static public void UserChoice()
        {
            int Choice = int.Parse(Console.ReadLine());
            if (Choice == 00)
            {
                Environment.Exit(0);
            }
            if (ChoiceDict.TryGetValue(Choice, out Action action))
            {
                action();
            }

        }
    }
}