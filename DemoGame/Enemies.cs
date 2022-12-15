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
        public static int[] Enemy= new int[3]{100,10,5};
        public static int[] GetEnemys
        {
            get => Enemy;
            set => Enemy = value;
        }
        public static void En()
        {
            
            for (int i = map.palya.Length - 1; i >= 0; i--)
            {
                if (map.palya[i]=="Y")
                {
                    if (map.palya[i-1]=="X")
                    {
                        player.jatekos[0] -= 10;
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