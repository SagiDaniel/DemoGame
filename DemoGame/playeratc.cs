using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoGame;


namespace DemoGame
{
    public class playeratc
    {
        public static void playerattack(string ellenfel, string karakter)
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
                Archer archer = new Archer();
                if (ellenfel == "lloyd")
                {
                    archer.SetBasicAttack1 = rnd.Next(12, 15);
                    archer.SetBasicAttack2 = rnd.Next(12, 16);
                    archer.SetBasicAttack3 = rnd.Next(12, 17);
                }
                else
                {
                    archer.SetBasicAttack1 = rnd.Next(10, 13);
                    archer.SetBasicAttack2 = rnd.Next(10, 14);
                    archer.SetBasicAttack3 = rnd.Next(10, 15);
                }
            }
            else if ("geralt" == karakter)
            {
                Warrior warrior = new Warrior();
                if (ellenfel == "fallen")
                {
                    warrior.SetBasicAttack1 = rnd.Next(15, 18);
                    warrior.SetBasicAttack2 = rnd.Next(15, 16);
                    warrior.SetBasicAttack3 = rnd.Next(15, 20);
                }
                else
                {
                    warrior.SetBasicAttack1 = rnd.Next(13, 15);
                    warrior.SetBasicAttack2 = rnd.Next(13, 16);
                    warrior.SetBasicAttack3 = rnd.Next(13, 17);
                }
            }
        }
    }
}