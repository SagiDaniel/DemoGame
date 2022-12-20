namespace DemoGame
{
    public class win
    {
        public static void gyozelem(string beker)
        {
             if (beker=="lloyd")
            {
                for (int i = 0; i < enemies.Lloydmap.Length; i++)
                {
                    if (enemies.Lloydmap[i]==1)
                    {
                        enemies.Lloydmap[i] = 0;
                        if (i<4)
                        {
                            enemies.Lloydmap[i + 1] = 1;
                        }
                        
                        break;
                    }
                }
            }
            else if (beker=="fallen")
            {
                for (int i = 0; i < enemies.GetFallenmap.Length; i++)
                {
                    if (enemies.Fallenmap[i]==1)
                    {
                        enemies.Fallenmap[i] = 0;
                        if (i < 4)
                        {
                            enemies.Fallenmap[i + 1] = 1;
                        }

                        break;
                    }
                }
            }
            else if ("Kingdom" == beker)
            {
                for (int i = 0; i < enemies.Kingdomnmap.Length; i++)
                {
                    if (enemies.Kingdomnmap[i]==1)
                    {
                        enemies.Kingdomnmap[i] = 0;
                        if (i < 4)
                        {
                            enemies.Kingdomnmap[i + 1] = 1;
                        }

                        break;
                    }
                }
            }

             player.jatekos[3] += 100;
             player.jatekos[0] = 100;
             enemies.Enemylevel(beker);
        }
    }
}