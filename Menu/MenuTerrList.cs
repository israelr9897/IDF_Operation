namespace IDF_Operation.Models
{
    internal static class MenuTerrList 
    {
        static bool Loop = true;
        static Dictionary<int, Action> ChoiceDict = new Dictionary<int, Action>
        {
            {1, MenuTerrSort.UserChoice},
            {2,MenuSearchTerr.UserChoice},
            {0,MenuTerroists.UserChoice},
            {00, ToFalse}
        };

        static public void UserChoice()
        {
            System.Console.WriteLine($"Please select the desired option -\n" +
                                    "1. Sort \n" +
                                    "2. Search terrorist by ID\n" +
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