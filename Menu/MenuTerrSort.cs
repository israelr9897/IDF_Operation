namespace IDF_Operation.Models
{
    static class MenuTerrSort
    {
        static Dictionary<int, Action> ChoiceDict = new Dictionary<int, Action>
        {
            {1, SortTerroist.SortingByRisk().Print},
            {2, SortTerroist.SortedNumberReports().Print},
            {11, MenuTerrList.MenuPrint},
        };

        static public void MenuPrint()
        {
            System.Console.WriteLine($"Please select the desired option -\n" +
                                    "1.  Sort by risk\n" +
                                    "2.  Sort by most reports \n" +
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