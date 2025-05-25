namespace IDF_Operation.Models
{
    static class HamasPrint
    {
        public static void Print(this Terrorist obj)
        {
            string weaponsSTR = String.Join(",", obj.Weapons);
            //foreach (var weapon in Weapons) { weaponsSTR += weapon + " "; };
            Console.WriteLine($"Terrorist,\nId: {obj.Id}\nName: {obj.Name},\nRank: {obj.Rank},\nStatus: {obj.Status},\nWeapons: {weaponsSTR}.\n");
        }
        public static void Print(this List<Terrorist> list)
        {
            foreach (var terroist in list)
            {
                terroist.Print();
            }
        }
        public static void Print(this List<Dictionary<Terrorist, int>> list)
        {
            foreach (var dict in list)
            {
                foreach (var key in dict)
                {
                    key.Key.Print();
                    System.Console.WriteLine($"Reports number: {key.Value}\n\n");
                }
            }
        }
    }
}
