using System;

namespace DemoGame
{
    public class skill : Views
    {
        private int tamadas=0;
        private int vedekezes=0;
        private int maxhap=0;
        private int hpregen=0;

        public int Tamadas
        {
            get => tamadas;
            set => tamadas =tamadas++;
        }

        public int Vedekezes
        {
            get => vedekezes;
            set => vedekezes = vedekezes++;
        }

        public int Maxhap
        {
            get => maxhap;
            set => maxhap = maxhap++;
        }
        
    }
}