namespace IDF_Operation.Models
{
    static class MenuTerroists
    {
        static int Choice;
        static Dictionary<int, Action> ChoiceDict = new Dictionary<int, Action>
        {
            {1, Hamas.TerroristsListPrint},
        };
        // static MenuTerroists()
        // {
        // }

        static public void UserChoice()
        {
            System.Console.WriteLine($"Please select the desired option -\n" +
                                    "1. Show the list of terrorists\n" +
                                    "2. Show the most dangerous terrorist\n" +
                                    "3. Show the terrorist with the most reports\n" +
                                    "4. Show the terrorist with the most recent report\n" +
                                    "5. Return to the main menu.");
            int Choice = int.Parse(Console.ReadLine());
            if (ChoiceDict.TryGetValue(Choice, out Action action))
            {
                action();
            }

        }
    }
}