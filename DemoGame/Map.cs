using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGame
{
    public class Map
    {
        //0kesz 
        //1folyamatban
        //2nincskesz
        //Lloyd Kingdom
        public int[] Lloydmap = new int[5]{1,2,2,2,2};
        //Fallen Kingdom
        public int[] Fallenmap = new int[5]{1,2,2,2,2};
        //Dwarf Kingdom
        public int[] Kingdomnmap = new int[5]{1,2,2,2,2};

        public static void maps(string ellenfel, string karakter)
        {
            Random rnd = new Random();
            if ("fiora" == karakter)
            {
                Wizard varazslo = new Wizard();
                if (ellenfel == "dwarf")
                {
                    varazslo.SetBasicAttack1 = rnd.Next(12, 15);
                    varazslo.SetBasicAttack2 = rnd.Next(12, 16);
                    varazslo.SetBasicAttack3 = rnd.Next(12, 17);
                }
                else
                {
                    varazslo.SetBasicAttack1 = rnd.Next(10, 13);
                    varazslo.SetBasicAttack2 = rnd.Next(10, 14);
                    varazslo.SetBasicAttack3 = rnd.Next(10, 15);
                }

            }
            else if ("hawk" == karakter)
            {

            }
            else if ("geralt" == karakter)
            {

            }

        }
    }
}