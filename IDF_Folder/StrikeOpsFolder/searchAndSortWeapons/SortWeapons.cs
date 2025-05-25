namespace IDF_Operation.Models
{
    static class SortWeapons
    {
        public static List<StrikeOptions> SortWeaponType(string type)
        {
            List<StrikeOptions> weaponTypeList = new List<StrikeOptions>();
            foreach (var weapon in Idf.StrikeOptionsList)
            {
                if (weapon.Name == type)
                {
                    weaponTypeList.Add(weapon);
                }
            }
            return weaponTypeList;
        }
    }
}