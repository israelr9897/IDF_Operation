// namespace IDF_Operation.Models
// {
//     static class MenuSearchReport
//     {
//         static int Id;
//         static IntelReport report;
//         static Dictionary<int, Action> ChoiceDict = new Dictionary<int, Action>
//         {
//             {1, ViweTerroist},
//             {11, MenuTerrList.MenuPrint},
//         };

//         static MenuSearchReport()
//         {
//             System.Console.WriteLine("Please enter the ID ");
//             Id = int.Parse(Console.ReadLine());
//         }
//         static void ById()
//         {
//             report = SearchReports.SearchReportById(Id);
//             report.Print();

//         }
//         static void ByTerr()
//         {
//             report = SearchReports.SearchReportByTerroist(Id);
//             report.Print();

//         }
//         static public void MenuPrint()
//         {
//             System.Console.WriteLine($"Please select the desired option -\n" +
//                                     "1.  To see the terrorist\n" +
//                                     "11. Return to the main menu.\n" +
//                                     "00. Exit");
//             UserChoice();
//         }
//         static public void UserChoice()
//         {
//             int Choice = int.Parse(Console.ReadLine());
//             if (Choice == 00)
//             {
//                 Environment.Exit(0);
//             }
//             if (ChoiceDict.TryGetValue(Choice, out Action action))
//             {
//                 action();
//             }
//         }

//         static void ViweTerroist()
//         {
//             report.TerroristName.Print();
//             MenuAmanList.MenuPrint();
//         }
//     }
// }