namespace IDF_Operation.Models
{
    internal class MenuAttack
    {
        static string officer;
        static Terrorist Target;

        internal static void StartAttack(IntelReport intel)
        {
            System.Console.WriteLine("Please enter the name of the attack commander - ");
            officer = System.Console.ReadLine();
            Target = intel.TerroristName;
            if (Checkin())
            {
                UserInterface.AttackCase(officer, intel);
            }
            else
            {
                SubMenu.MiniReportMenuPrint();
            }
        }

        static bool Checkin()
        {
            bool approval = false;
            System.Console.WriteLine("Attention!\n" +
                                    $"You are going to attack {Target.Name}\n" +
                                    "Are you sure about carrying out the attack? (Y/N)");
            string answer = Console.ReadLine();
            return answer == "Y";
        }

    }
}