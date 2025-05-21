using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IDF_Operation.HamasFolder.terrorist
{
    internal class Terrorist
    {
        public string Name { get;}
        public int Rank { get; }
        public string Status { get; set; }
        public List<string> Weapons { get;}


        public Terrorist(string name, int rank, List<string> weapons) 
        {
            Name = name; 
            Rank = rank; 
            Status = "alive"; 
            Weapons = weapons;
        }

        public void Killed()
        {
            Status = "dead";
        }

        public void Print()
        {
            string weaponsSTR = "";
            foreach (var weapon in Weapons) { weaponsSTR += weapon; };
            Console.WriteLine($"Terrorist,\nName: {Name},\nRank: {Rank},\nStatus: {Status},\nWeapons: {weaponsSTR}.\n");
        }
    }
}
