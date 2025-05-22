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
        public string Name { get;}
        public int Id { get; }
        public int Rank { get; }
        public string Status { get; set; }
        public List<string> Weapons { get;}


        public Terrorist(string name, int id, int rank, List<string> weapons) 
        {
            Name = name;
            Id = id;
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
            string weaponsSTR = String.Join(",", Weapons);
            //foreach (var weapon in Weapons) { weaponsSTR += weapon + " "; };
            Console.WriteLine($"Terrorist,\nName: {Name},\nId: {Id}\nRank: {Rank},\nStatus: {Status},\nWeapons: {weaponsSTR}.\n");
        }
    }
}
