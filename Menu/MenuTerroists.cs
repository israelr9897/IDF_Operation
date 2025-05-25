using System.Diagnostics;

namespace IDF_Operation.Models
{
    static class MenuTerroists
    {
        static int Id;
        static Dictionary<int, Action[]> ChoiceDict = new Dictionary<int, Action[]>
        {
            {1, new Action[]{MenuTerrList.MenuPrint} },
            {2, new Action[]{ViweMustDenger,MiniMenuPrint,MenuPrint } },
            {3, new Action[]{ViewMustReport,MiniMenuPrint,MenuPrint}},
            {4, new Action[]{ViewRecentReport,MiniMenuPrint,MenuPrint}},
            {11, new Action[]{Menu.MenuPrint } },
        };
        static Dictionary<int, Action[]> MiniChoiceDict = new Dictionary<int, Action[]>
        {
            {1, new Action[]{ViweReports,MiniMenuPrint}},
            {11, new Action[] {MenuPrint}},
        };

        static MenuTerroists()
        {
            MenuPrint();
        }

        static public void MenuPrint()
        {
            System.Console.WriteLine($"Please select the desired option -\n" +
                                    "1.  Show the list of terrorists\n" +
                                    "2.  Show the most dangerous terrorist\n" +
                                    "3.  Show the terrorist with the most reports\n" +
                                    "4.  Show the terrorist with the most recent report\n" +
                                    "11. Return to the main menu.\n" +
                                    "00. Exit");
            UserChoice(ChoiceDict);
        }
        static public void MiniMenuPrint()
        {
            System.Console.WriteLine($"Please select the desired option -\n" +
                                    "1.  To view the terrorist reports\n" +
                                    "11. Return to the main menu.\n" +
                                    "00. Exit");
            UserChoice(MiniChoiceDict);
        }


        static public void UserChoice(Dictionary<int, Action[]> dict)
        {
            int choice = int.Parse(Console.ReadLine());
            if (choice == 00)
            {
                Environment.Exit(0);
            }
            if (dict.TryGetValue(choice, out Action[] action))
            {
                foreach (var item in action)
                {
                    item();
                }
            }

        }

        static private void ViweMustDenger()
        {
            SearchTerroist.SearchTerrMostDanger().Print();
            Id = SearchTerroist.SearchTerrMostDanger()[0].Id;
        }

        static private void ViewMustReport()
        {
            SearchTerroist.SearchTerrMostReports().Print();
            Id = SearchTerroist.SearchTerrMostReports()[0].Id;
        }
        static private void ViewRecentReport()
        {
            SortReport.SortReportsByDate().Print();
            Id = SortReport.SortReportsByDate()[0].TerroristName.Id;
        }
        static internal void ViweReports()
        {
            SearchReports.SearchReportByTerroist(Id).Print();
        }
    }
}