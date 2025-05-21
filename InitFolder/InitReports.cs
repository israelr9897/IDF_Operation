using IDF_Operation.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace IDF_Operation.Models
{
    internal class InitReports
    {
        
        //public static string[] FirstName = new string[]
        //{
        //    "Mohammad", "Ahmad", "Yousef", "Omar", "Ali",
        //    "Lina", "Rania", "Mariam", "Nour", "Dina"
        //};
        //public static string[] MiddleName = new string[]
        //{
        //    "Ibrahim", "Khalil", "Issa", "Mahmoud", "Fadi",
        //    "Nabil", "Suleiman", "Tariq", "Hassan", "Rashid"
        //};
        //public static string[] LastName = new string[]
        //{
        //    "Al-Tamimi", "Barghouti", "Nashashibi", "Abu Sneineh", "Awad",
        //    "Dweik", "Hijazi", "Sabbagh", "Salameh", "Zayyad"
        //};
        //public static string[] WeaponsTypes = new string[] { "knife", "gun", "M16", "AK47"};
        //private Random random = new Random();

        //public InitReports(int amount) 
        //{
        //    for (int i = 0; i < amount; i++)
        //    {
        //        Hamas.Terrorists.Add(new Terrorist(
        //            GenerateName(),
        //            random.Next(1, 6),
        //            GenerateWeapons())
        //            );
        //    }
        //}
        
        //private string GenerateName() 
        //{
        //    string name = "";
        //    name += FirstName[random.Next(10)] + " ";
        //    name += MiddleName[random.Next(10)] + " ";
        //    name += LastName[random.Next(10)];
        //    return name;
        //}

        //private List<string> GenerateWeapons()
        //{
        //    List<string> weapons = new List<string>();
        //    int amount = random.Next(1,4);
        //    for (int i = 0; i < amount; i++)
        //    {
        //        int type = random.Next(4);
        //        if (weapons.Contains(WeaponsTypes[type])){
        //            continue;
        //        }
        //        weapons.Add(WeaponsTypes[type]);
        //    }
        //    return weapons;
        //}
    }
}
