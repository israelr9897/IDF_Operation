namespace IDF_Operation.Models
{
    static class Menu
    {
        static Dictionary<int, Action[]> ChoiceDict = new Dictionary<int, Action[]>
        {
            {1, new Action[]{MenuTerroists.MenuPrint} },
            {2, new Action[]{Idf.StrikeOptionsList.Print} },
            {3, new Action[]{MenuReport.MenuPrint} },
            // {1, MenuTerroists.UserChoice},
            {100, new Action[]{SubMenu.ChoiceReport, SubMenu.StartAttack}}
        };
        static public void MenuPrint()
        {
            System.Console.WriteLine($"\n\n" +
                                      "Please select the desired option -\n" +
                                      "--------------\n" +
                                      "1.   Terrorists\n" +
                                      "2.   Weapons\n" +
                                      "3.   Reports\n" +
                                      "4.   System recommendation for attack\n" +
                                      "100. Attack\n" +
                                      "99.  Exit\n" +
                                      "--------------");
            UserChoiceCheck.UserChoice(ChoiceDict);
        }
    }
}