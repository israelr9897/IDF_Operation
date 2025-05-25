namespace IDF_Operation.Models
{
    static class SearchWeapon
    {
        public static StrikeOptions SearchWeaponById(int id)
        {
            foreach (var weapon in Idf.StrikeOptionsList)
            {
                if (weapon.Id == id)
                {
                    return weapon;
                }
            }
            return null;
        }
    }
}