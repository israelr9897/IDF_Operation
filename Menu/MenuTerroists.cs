namespace IDF_Operation.Models
{
    static class MenuTerroists
    {
        static int Id;
        static bool Loop = true;
        static Dictionary<int, Action> ChoiceDict = new Dictionary<int, Action>
        {
            {1, MenuTerrList.UserChoice},
            {2, ViweMustDenger},
            {3, ViewMustReport},
            {4, ViewRecentReport},
            // {0, UserChoice},
            {00, ToFalse}
        };

        static MenuTerroists()
        {
            System.Console.WriteLine($"Please select the desired option -\n" +
                                    "1. Show the list of terrorists\n" +
                                    "2. Show the most dangerous terrorist\n" +
                                    "3. Show the terrorist with the most reports\n" +
                                    "4. Show the terrorist with the most recent report\n" +
                                    "0. Return to the main menu.\n" +
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
                    UserChoice();
                }

            }

        }

        static private void ViweMustDenger()
        {
            SearchTerroist.SearchTerrMostDanger().Print();
            Id = SearchTerroist.SearchTerrMostDanger()[0].Id;
            ViweReports();

        }

        static private void ViewMustReport()
        {
            SearchTerroist.SearchTerrMostReports().Print();
            Id = SearchTerroist.SearchTerrMostReports()[0].Id;
            ViweReports();
        }
        static private void ViewRecentReport()
        {
            SortReport.SortReportsByDate()[0].TerroristName.Print();
            Id = SortReport.SortReportsByDate()[0].TerroristName.Id;
            ViewMustReport();
        }
        static private void ViweReports()
        {
            SearchReports.SearchReportByTerroist(Id).Print();
            System.Console.WriteLine($"Please select the desired option -\n" +
                                    "0. Return to the main menu.\n" +
                                    "00. Exit");
            UserChoice();
        }
         static private void ToFalse()
        {
            Loop = false;
        }
    }
}