using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IDF_Operation.Models
{
    internal class Terrorist
    {
        public string Name { get; }
        public int Id { get; }
        public int Rank { get; }
        public string Status { get; set; }
        public List<string> Weapons { get; }
        public int LevelRisk { get; }


        public Terrorist(string name, int id, int rank, List<string> weapons)
        {
            Id = id;
            Name = name;
            Rank = rank;
            Status = "alive";
            Weapons = weapons;
            LevelRisk = Rank * ResultWeapons(Weapons);
        }

        public void Killed()
        {
            Status = "dead";
        }

        public void Print()
        {
            string weaponsSTR = String.Join(",", Weapons);
            //foreach (var weapon in Weapons) { weaponsSTR += weapon + " "; };
            Console.WriteLine($"Terrorist,\nId: {Id}\nName: {Name},\nRank: {Rank},\nStatus: {Status},\nWeapons: {weaponsSTR}.\n");
        }

        private static int ResultWeapons(List<string> weapons)
        {
            Dictionary<string, int> riskDict = new Dictionary<string, int>
            {
            {"knife", 1},
            {"gun", 2},
            {"M16", 3},
            {"AK47",3}
            };
            int result = 0;
            foreach (var weapon in weapons)
            {
                result += riskDict[weapon];
            }
            return result;
        }
    }
}
