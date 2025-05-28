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
        public static StrikeOptions StrickOpsCase(string location)
        {
            List<StrikeOptions> WeaponList = SearchWeapon.FilterWeaponByTarget(location);
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
        public static string AmmoCase(StrikeOptions StrikeOp, string location)
        {
            //send srtikeOp to func for user to choose the ammo type
            string ammoType = AmmutType(StrikeOp, location);
            return ammoType;
        }
        public static string AmmutType(StrikeOptions Type, string location)
        {
            string ammuType = "";
            if (Type.Name == "F16")
            {
                System.Console.WriteLine(Type.DictPrint());
                System.Console.WriteLine("Enter the ammunition type 1 or 0.5");
                ammuType = Console.ReadLine();

            }
            else if (Type.Name == "Zik 460")
            {
                if (location == "outside")
                {
                    ammuType = "personnel";
                }
                else
                {
                    ammuType = "armored vehicles";
                }
            }
            else
            {
                ammuType = "shell";
            }
            return ammuType;
        }



    }
}