namespace IDF_Operation.Models
{
    static public class UserChoiceCheck
    {
        static public void UserChoice(Dictionary<int, Action[]> dict)
        {
            int Choice = int.Parse(Console.ReadLine());
            if (Choice == 99)
            {
                Environment.Exit(0);
            }
            if (dict.TryGetValue(Choice, out Action[] action))
            {
                foreach (var item in action)
                {
                    item();
                }
            }
            else
            {
                System.Console.WriteLine("Invalid selection");
                Menu.MenuPrint();
            }
        }    
    }
}