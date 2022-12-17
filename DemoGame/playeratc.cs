using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoGame;
namespace DemoGame
{
    public class Playeratc
    {
        public static void playerattack(string ellenfel, string karakter)
        {
            Random rnd = new Random();
            int eros1 = rnd.Next(12,15);
            int eros2 = rnd.Next(12,16);
            int eros3 = rnd.Next(12,17);
            int gyenge1= rnd.Next(10, 13);
            int gyenge2=rnd.Next(10, 14);
            int gyenge3=rnd.Next(10, 15);
            if ("fiora" == karakter)
            {
                Wizard varazslo = new Wizard();
                if (ellenfel == "dwarf")
                {
                    varazslo.GetBasicAttack1 = eros1;
                    varazslo.GetBasicAttack2 = eros2;
                    varazslo.GetBasicAttack3 = eros3;
                }
                else
                {
                    varazslo.GetBasicAttack1 = gyenge1;
                    varazslo.GetBasicAttack2 = gyenge2;
                    varazslo.GetBasicAttack3 = gyenge3;
                }
            }
            else if ("hawk" == karakter)
            {
                Archer archer = new Archer();
                if (ellenfel == "lloyd")
                {
                    archer.SetBasicAttack1 = eros1;
                    archer.SetBasicAttack2 = eros2;
                    archer.SetBasicAttack3 = eros3;
                }
                else
                {
                    archer.SetBasicAttack1 = gyenge1;
                    archer.SetBasicAttack2 = gyenge2;
                    archer.SetBasicAttack3 = gyenge3;
                }
            }
            else if ("geralt" == karakter)
            {
                Warrior warrior = new Warrior();
                if (ellenfel == "fallen")
                {
                    warrior.SetBasicAttack1 = eros1;
                    warrior.SetBasicAttack2 = eros2;
                    warrior.SetBasicAttack3 = eros3;
                }
                else
                {
                    warrior.SetBasicAttack1 = gyenge1;
                    warrior.SetBasicAttack2 = gyenge2;
                    warrior.SetBasicAttack3 = gyenge3;
                }
            }
        }
    }
}