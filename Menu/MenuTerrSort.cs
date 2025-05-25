namespace IDF_Operation.Models
{
    static class MenuTerrSort
    {
        static bool Loop = true;
        static Dictionary<int, Action> ChoiceDict = new Dictionary<int, Action>
        {
            {1, SortTerroist.SortingByRisk().Print},
            {2,SortTerroist.SortedNumberReports().Print},
            {0,MenuTerroists.UserChoice},
            {00, ToFalse}
        };

        static public void UserChoice()
        {
            System.Console.WriteLine($"Please select the desired option -\n" +
                                    "1. Sort by risk\n" +
                                    "2. Sort by most reports \n" +
                                    "0. Return to the back menu.\n" +
                                    "00. To Exit");
            int Choice = int.Parse(Console.ReadLine());
            if (ChoiceDict.TryGetValue(Choice, out Action action))
            {
                action();
                if (Loop)
                {
                    MenuTerroists.UserChoice();
                }

            }

        }

        static private void ToFalse()
        {
            Loop = false;
        }
    }
}