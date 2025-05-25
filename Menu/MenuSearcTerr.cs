namespace IDF_Operation.Models
{
    static class MenuSearchTerr
    {
        static int Id;
        static bool Loop = true;
        static Dictionary<int, Action> ChoiceDict = new Dictionary<int, Action>
        {
            // {1, ViweReports},
            {0,MenuTerrList.UserChoice},
            {00, ToFalse}
        };

        static MenuSearchTerr()
        {
            System.Console.WriteLine("Please enter the terrorist's ID ");
            Id = int.Parse(Console.ReadLine());
        }

        static public void UserChoice()
        {
            SearchTerroist.SearchTerroistById(Id).Print();
            System.Console.WriteLine($"Please select the desired option -\n" +
                                    "1. To view the terrorist reports\n" +
                                    "0. Return to the main menu.\n" +
                                    "00. Exit");
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