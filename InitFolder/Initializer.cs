using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// import all init classes
using IDF_Operation.InitFolder.init_terrorists;

namespace IDF_Operation.InitFolder.initializer
{
    internal class Initializer
    {
        public Initializer() 
        {
            //Initialize AttackOps

            //Initialize IDF officers

            //Initialize Hamas Terrorists

            private InitTerrorists terrorists = new InitTerrorists();
            terrorists.init();

        //Initialize Intel Reports

    }
    }
}
