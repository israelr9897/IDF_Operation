using IDF_Operation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.Models
{
    internal class Initializer
    {
        private InitTerrorists terrorists;

        public Initializer()
        {
            //Initialize AttackOps

            //Initialize IDF officers

            //Initialize Hamas Terrorists
            terrorists = new InitTerrorists(10);
            foreach (Terrorist item in Hamas.Terrorists)
            {
                item.Print();
            }

        //Initialize Intel Reports
        }
    }
}




