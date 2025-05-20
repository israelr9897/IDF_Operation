using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.terrorist
{
    internal class Terrorist
    {
        public string Name { get;}
        public int Rank { get; }
        public string Status { get; set; }
        public List<string> Weapons { get;}


        public Terrorist(string name, int rank, string status, List<string> weapons) 
        {
            Name = name; 
            Rank = rank; 
            Status = status; 
            Weapons = weapons;
        }
    }
}
