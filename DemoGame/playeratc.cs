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
        private static Random rnd = new Random();
        private static int eros1 = rnd.Next(12,15);
        private static int eros2 =  rnd.Next(12,16);
        private static int eros3 = eros3 = rnd.Next(12,17);
        public static int GetEros1
        {
            get => eros1;
        }

        public static int GetEros2
        {
            get => eros2;
        }


        public static int GetEros3
        {
            get => eros3;
        }
        private static int gyenge1 = rnd.Next(10,13);
        private static int gyenge2 = rnd.Next(10,14);
        private static int gyenge3 = rnd.Next(10,15);

        public static int GetGyenge1
        {
            get => gyenge1;
        }

        public static int GetGyenge2
        {
            get => gyenge2;
        }

        public static int GetGyenge3
        {
            get => gyenge3;
        }

        public static void playerattack(string ellenfel, string karakter)
        {
            if ("fiora" == karakter)
            {
                Wizard varazslo = new Wizard();
                if (ellenfel == "dwarf")
                {
                    varazslo.GetBasicAttack1 = GetEros1;
                    varazslo.GetBasicAttack2 = GetEros2;
                    varazslo.GetBasicAttack3 = GetEros3;
                }
                else
                {
                    varazslo.GetBasicAttack1 = GetGyenge1;
                    varazslo.GetBasicAttack2 = GetGyenge2;
                    varazslo.GetBasicAttack3 = GetGyenge3;
                }
            }
            else if ("hawk" == karakter)
            {
                Archer archer = new Archer();
                if (ellenfel == "lloyd")
                {
                    archer.SetBasicAttack1 = GetEros1;
                    archer.SetBasicAttack2 = GetEros2;
                    archer.SetBasicAttack3 = GetEros3;
                }
                else
                {
                    archer.SetBasicAttack1 = GetGyenge1;
                    archer.SetBasicAttack2 = GetGyenge2;
                    archer.SetBasicAttack3 = GetGyenge3;
                }
            }
            else if ("geralt" == karakter)
            {
                Warrior warrior = new Warrior();
                if (ellenfel == "fallen")
                {
                    warrior.SetBasicAttack1 = GetEros1;
                    warrior.SetBasicAttack2 = GetEros2;
                    warrior.SetBasicAttack3 = GetEros3;
                }
                else
                {
                    warrior.SetBasicAttack1 = GetGyenge1;
                    warrior.SetBasicAttack2 = GetGyenge2;
                    warrior.SetBasicAttack3 = GetGyenge3;
                }
            }
        }
    }
}