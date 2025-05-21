using IDF_Operation.HamasFolder.terrorist;
using IDF_Operation.HamasFolder.hamas;

using IDF_Operation.IDF_Folder.StrikeOpsFolder.f16;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace IDF_Operation.InitFolder.init_terrorists
{
    internal class InitTerrorists
    {
        
        public static string[] FirstName = new string[]
        {
            "Mohammad", "Ahmad", "Yousef", "Omar", "Ali",
            "Lina", "Rania", "Mariam", "Nour", "Dina"
        };
        public static string[] MiddleName = new string[]
        {
            "Ibrahim", "Khalil", "Issa", "Mahmoud", "Fadi",
            "Nabil", "Suleiman", "Tariq", "Hassan", "Rashid"
        };
        public static string[] LastName = new string[]
        {
            "Al-Tamimi", "Barghouti", "Nashashibi", "Abu Sneineh", "Awad",
            "Dweik", "Hijazi", "Sabbagh", "Salameh", "Zayyad"
        };
        public static string[] WeaponsTypes = new string[] { "knife", "gun", "M16", "AK47" };
        private Random random = new Random();

        public InitTerrorists(int amount) 
        {
            for (int i = 0; i < amount; i++)
            {
                Hamas.Terrorists.Add(new Terrorist(GenerateName(),
                    random.Next(1, 6),
                    GenerateWeapons())
                    );
            }
        }
        public List<Terrorist>  Init(int amount) {
            List<Terrorist> Terrorists = new List<Terrorist>();

            for (int i = 0; i < amount; i++)
            {
                    Terrorists.Add(
                    new Terrorist(GenerateName(), 
                    random.Next(1,6), 
                    GenerateWeapons())
                    );
            }
            return Terrorists;
        }
        private string GenerateName() 
        {
            string name = "";
            name += FirstName[random.Next(10)] + " ";
            name += MiddleName[random.Next(10)] + " ";
            name += LastName[random.Next(10)];
            return name;
        }

        private List<string> GenerateWeapons()
        {
            List<string> weapons = new List<string>();
            int amount = random.Next(4);
            for (int i = 0; i < amount; i++)
            {
                int type = random.Next(4);
                weapons.Add(WeaponsTypes[type]);
            }
            return weapons;
        }
    }
}
