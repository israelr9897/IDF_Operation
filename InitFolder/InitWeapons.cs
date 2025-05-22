namespace IDF_Operation.Models
{
    class InitWeapons
    {
        // private StrikeOptions[] WeaponList = { StrikeOptions, Zik, M109 };
        // private Random random = new Random()
        public InitWeapons(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Idf.StrikeOptionsList.Add(new F16(100, " "));
                Idf.StrikeOptionsList.Add(new Zik(100));
                Idf.StrikeOptionsList.Add(new M109(100));
                // string weaponChoice = WeaponList[random.Next(3)];
            }
        }
        
    
    }
}