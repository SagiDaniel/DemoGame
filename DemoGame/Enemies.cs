namespace DemoGame
{
    //0kesz 
    //1folyamatban
    //2nincskesz
    public class enemies
    {
        public static int[] Kingdomnmap = new int[5]{1,2,2,2,2};
        public static int[] GetKingdomnmap
        {
            get => Kingdomnmap;
            set => Kingdomnmap = value;
        }
        public static int[] Fallenmap = new int[5]{1,2,2,2,2};
        public static int[] GetFallenmap
        {
            get => Fallenmap;
            set => Fallenmap = value;
        }
        public static int[] Lloydmap = new int[5]{1,2,2,2,2};
        public static int[] GetLloydmap
        {
            get => Lloydmap;
            set => Lloydmap = value;
        }
        /*
         hp
         atc
         def
         */
        public static int[] Enemy= new int[3]{100,10,0};
        public static int[] GetEnemys
        {
            get => Enemy;
            set => Enemy = value;
        }

        public static void Enemylevel(string bekerenemy)
        {
            if (bekerenemy=="lloyd")
            {
                for (int i = 0; i <Lloydmap.Length; i++)
                {
                    if (Lloydmap[1]==1)
                    {
                        
                        Enemy[0] = 100;
                        Enemy[1] = 10;
                    }
                    else if(Lloydmap[2]==1)
                    {
                        
                        Enemy[0] = 140;
                        Enemy[1] = 20;
                    }
                    else if(Lloydmap[3]==1)
                    {
                        
                        Enemy[0] = 160;
                        Enemy[1] = 25;
                    }
                    else if(Lloydmap[4]==1)
                    {
                        
                        Enemy[0] = 180;
                        Enemy[1] = 30;
                    }
                    if (Lloydmap[i]==1)
                    {
                        Lloydmap[i] = 0;
                        if (i<4)
                        {
                            Lloydmap[i + 1] = 1;
                        }
                        break;
                    }
                }
            }
            else if (bekerenemy=="fallen")
            {
                for (int i = 0; i <Fallenmap.Length; i++)
                {
                    if (Fallenmap[1]==1)
                    {
                       
                        Enemy[0] = 100;
                        Enemy[1] = 10;
                    }
                    else if(Fallenmap[2]==1)
                    {
                        
                        Enemy[0] = 140;
                        Enemy[1] = 20;
                    }
                    else if(Fallenmap[3]==1)
                    {
                        
                        Enemy[0] = 160;
                        Enemy[1] = 25;
                    }
                    else if(Fallenmap[4]==1)
                    {
                        
                        Enemy[0] = 180;
                        Enemy[1] = 30;
                    }
                    if (Fallenmap[i]==1)
                    {
                        Fallenmap[i] = 0;
                        if (i<4)
                        {
                            Fallenmap[i + 1] = 1;
                        }
                        break;
                    }
                }
            }
            else if ("Kingdom" == bekerenemy)
            {
                for (int i = 0; i <Kingdomnmap.Length; i++)
                {
                    if (Kingdomnmap[1]==1)
                    {
                      
                        Enemy[0] = 100;
                        Enemy[1] = 10;
                    }
                    else if(Kingdomnmap[2]==1)
                    {
                       
                        Enemy[0] = 140;
                        Enemy[1] = 20;
                    }
                    else if(Kingdomnmap[3]==1)
                    {
                        
                        Enemy[0] = 160;
                        Enemy[1] = 25;
                    }
                    else if(Kingdomnmap[4]==1)
                    {
                        
                        Enemy[0] = 180;
                        Enemy[1] = 30;
                    }
                    if (Kingdomnmap[i]==1)
                    {
                        Kingdomnmap[i] = 0;
                        if (i<4)
                        {
                            Kingdomnmap[i + 1] = 1;
                        }
                        break;
                    }
                }
            }
        }
        public static void En()
        {
            for (int i = map.palya.Length - 1; i >= 0; i--)
            {
                if (map.palya[i]=="Y")
                {
                    if (map.palya[i-1]=="X")
                    {
                       armor.Enemydamage();
                    }
                    else
                    {
                        map.palya[i] = "_";
                        map.palya[i - 1] = "Y";
                        break;
                    }
                }
            }
        }
    }
}