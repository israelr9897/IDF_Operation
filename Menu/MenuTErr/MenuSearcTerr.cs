// namespace IDF_Operation.Models
// {
//     static class MenuSearchTerr
//     {
//         static int Id;
//         static Dictionary<int, Action> ChoiceDict = new Dictionary<int, Action>
//         {
//             {1, ViweReports},
//             {9, MenuTerrList.MenuPrint},
//         };

//         static MenuSearchTerr()
//         {
//             System.Console.WriteLine("Please enter the terrorist's ID ");
//             Id = int.Parse(Console.ReadLine());
//             SearchTerroist.SearchTerroistById(Id).Print();
//         }
//         static public void MenuPrint()
//         {
//             System.Console.WriteLine($"Please select the desired option -\n" +
//                                     "1. To view the terrorist reports\n" +
//                                     "9. Return to the main menu.\n" +
//                                     "99. Exit");
//             UserChoice();
//         }
//         static public void UserChoice()
//         {
//             int Choice = int.Parse(Console.ReadLine());
//             if (Choice == 99)
//             {
//                 Environment.Exit(0);
//             }
//             if (ChoiceDict.TryGetValue(Choice, out Action action))
//             {
//                 action();
//             }
//         }

//         static void ViweReports()
//         {
//             SearchReports.SearchReportByTerroist(Id).Print();
//             MenuTerrList.MenuPrint();
//         }
//     }
// }