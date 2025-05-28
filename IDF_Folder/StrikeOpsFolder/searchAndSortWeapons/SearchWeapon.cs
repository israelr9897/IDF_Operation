using System.Collections.Generic;

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

        public static List<StrikeOptions> FilterWeaponByTarget(string target)
        {
            List<StrikeOptions> filterTargetWeapon = new List<StrikeOptions>();
            foreach (var weapon in Idf.StrikeOptionsList)
            {
                if (weapon.TargetType.Contains(target))
                {
                    filterTargetWeapon.Add(weapon);
                }
            }
            return filterTargetWeapon;
        }

        public static List<StrikeOptions> SearchStrikeOpsByType(string name)
        {
            List<StrikeOptions> list = new List<StrikeOptions>();
            foreach (StrikeOptions StrikeOp in Idf.StrikeOptionsList)
            {
                if (StrikeOp.Name == name)
                {
                    list.Add(StrikeOp);
                }
            }
            return list;
        }
    }
}