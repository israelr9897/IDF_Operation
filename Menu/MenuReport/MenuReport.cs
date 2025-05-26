namespace IDF_Operation.Models
{
    static class MenuReport
    {
        static Dictionary<int, Action[]> ChoiceDict = new Dictionary<int, Action[]>
        {
            {1, new Action[]{Aman.ReportList.Print,MenuAmanList.MenuPrint } },
            // {2, new Action[]{ViweMunger,SubMenu.MiniMenuPrint,MenuPrint } },
            {9, new Action[]{Menu.MenuPrint } },
        };

        // static MenuReport()
        // {
        //     MenuPrint();
        // }
        static public void MenuPrint()
        {
            System.Console.WriteLine($"Please select the desired option -\n" +
                                    "1.  To the list of Intelligence Division reports\n" +
                                    "2.  To the list of attack reports\n" +
                                    "9.  Return to the main menu.\n" +
                                    "99. Exit");
            UserChoiceCheck.UserChoice(ChoiceDict);
        }

        // static public void UserChoice(Dictionary<int, Action[]> dict)
        // {
        //     int choice = int.Parse(Console.ReadLine());
        //     if (choice == 99)
        //     {
        //         Environment.Exit(0);
        //     }
        //     if (dict.TryGetValue(choice, out Action[] action))
        //     {
        //         foreach (var item in action)
        //         {
        //             item();
        //         }
        //     }
        // }
    }
}