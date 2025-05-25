namespace IDF_Operation.Models
{
    static class Menu
    {
        static int Id;
        static bool Loop = true;
        static Dictionary<int, Action> ChoiceDict = new Dictionary<int, Action>
        {
            {1, MenuTerroists.UserChoice},
            // {2, Me.UserChoice},
            // {1, Men.UserChoice},
            // {1, MenuTerroists.UserChoice},
            // {1, MenuTerroists.UserChoice},
            {00, ToFalse}
        };

        static Menu()
        {
            System.Console.WriteLine($"Please select the desired option -\n" +
                                    "1. Terrorists\n" +
                                    "2. Weapons\n" +
                                    "3. Reports\n" +
                                    "4. System recommendation for attack\n" +
                                    "5. Attack\n" +
                                    "00. Exit");
        }

        static public void UserChoice()
        {            
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