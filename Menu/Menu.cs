namespace IDF_Operation.Models
{
    static class Menu
    {
        static Dictionary<int, Action[]> ChoiceDict = new Dictionary<int, Action[]>
        {
            {1, new Action[]{MenuTerroists.MenuPrint} },
            // {2, Men.UserChoice},
            {3, new Action[]{MenuReport.MenuPrint} }
            // {1, MenuTerroists.UserChoice},
            // {1, MenuTerroists.UserChoice},
        };

        static Menu()
        {
            MenuPrint();
        }

        static public void MenuPrint()
        {
            System.Console.WriteLine($"Please select the desired option -\n" +
                                      "1.  Terrorists\n" +
                                      "2.  Weapons\n" +
                                      "3.  Reports\n" +
                                      "4.  System recommendation for attack\n" +
                                      "5.  Attack\n" +
                                      "99. Exit");
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
    }
}