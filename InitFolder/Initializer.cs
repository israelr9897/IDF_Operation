﻿using IDF_Operation.Models;
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
        private InitReports reports;
        private InitWeapons weapons;

        public Initializer()
        {
            //Initialize AttackOps
            weapons = new InitWeapons(10);

            //Initialize IDF officers

            //Initialize Hamas Terrorists
            terrorists = new InitTerrorists(10);


            //Initialize Intel Reports
            reports = new InitReports(10);
            Aman.ReportList = SortReport.SortReportsByDate();
        }
    }
}



