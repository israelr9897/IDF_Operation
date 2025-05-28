using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDF_Operation.Models;


namespace IDF_Operation.Models
{
    internal class StrikeOpsOverview
    {
        public StrikeOptions StrickOpsCase(string location)
        {
            List<StrikeOptions> WeaponList = SearchWeapon.FilterWeaponByType(location);
            int SelectedStrickOp = ChooseStrickOp(WeaponList);
            return SearchWeapon.SearchWeaponById(SelectedStrickOp);
        }

        private static int ChooseStrickOp(List<StrikeOptions> WeaponList)
        {
            Console.WriteLine("Select Strick Option By entering it's ID: ");
            WeaponsPrint.Print(WeaponList);
            int StrickOpID = Convert.ToInt32(Console.ReadLine());
            return StrickOpID;
        }

        public static string AmmoCase(StrikeOptions StrikeOp)
        {
            //send srtikeOp to func for user to choose the ammo type
            string ammoType = "";
            return ammoType;
        }


    }
}