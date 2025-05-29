namespace IDF_Operation.Models
{
    static class MenuReport
    {
        static Dictionary<int, Action[]> ChoiceDict = new Dictionary<int, Action[]>
        {
            {1, new Action[]{Aman.ReportList.Print, MenuAmanList.MenuPrint } },
            {2, new Action[]{PrintAtteckLog, MenuPrint } },
            {9, new Action[]{Menu.MenuPrint } },
        };
        static public void MenuPrint()
        {
            System.Console.WriteLine($"\n\nPlease select the desired option -\n" +
                                    "--------------\n" +
                                    "1.  To the list of Intelligence Division reports\n" +
                                    "2.  To the list of attack reports\n" +
                                    "9.  Return to the main menu.\n" +
                                    "99. Exit\n" +
                                    "--------------\n");
            UserChoiceCheck.UserChoice(ChoiceDict);
        }
        public static void PrintAtteckLog()
        {
            if (Idf.AttackLogList.Count() == 0)
            {
                System.Console.WriteLine("\nNo attack reports have been generated yet.");
            }
            else
            {
                Idf.AttackLogList.Print();
            }
        }
    }
}