using System;
using System.Security.Policy;

namespace DemoGame
{
    public class armor
    {
        private static int playerarmor = 0;

        public static int GetPlayerarmor
        {
            get => playerarmor;
            set => playerarmor = value;
        }
        public  static void Heroarmor()
        {
           //head
            if (player.inv[4] == 1)
            {
                GetPlayerarmor += 25;
            }
            //stomach
            if (player.inv[5] == 1)
            {
                GetPlayerarmor += 35;
            }
            //legs
            if (player.inv[6] == 1)
            {
                GetPlayerarmor += 25;
            }
            //shoes
            if (player.inv[7] == 1)
            {
                GetPlayerarmor += 15;
            }
        }

    public static void Enemydamage()
        {
            if (GetPlayerarmor>0)
            {
                GetPlayerarmor -= enemies.Enemy[1];
                if (GetPlayerarmor<1)
                {
                    GetPlayerarmor = 0;
                }
                //max
                int head = 25;
                int stomach = 35;
                int legs = 25;
                int shoea = 15;
                if (player.inv[4]==1)
                {
                    head -= enemies.Enemy[1];
                    if (head<1)
                    {
                        player.inv[4] = 0;
                    }
                }
                else if (player.inv[5]==1)
                {
                    stomach -= enemies.Enemy[1];
                    if (stomach<1)
                    {
                        player.inv[5] = 0;
                    }
                }
                else if (player.inv[6]==1)
                {
                    legs -= enemies.Enemy[1];
                    if (legs<1)
                    {
                        player.inv[6] = 0;
                    }
                }
                else if (player.inv[7]==1)
                {
                    shoea -= enemies.Enemy[1];
                    if (shoea<1)
                    {
                        player.inv[7] = 0;
                    }
                }
            }
            else
            {
                player.jatekos[0] -= enemies.Enemy[1];
            }
            
        }
    }
}