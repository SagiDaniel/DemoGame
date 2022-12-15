using System;

namespace DemoGame
{
    public class Skill
    {
        private int tamadas=0;
        private int vedekezes=0;
        private int maxhap=0;

        public int Tamadas
        {
            get => tamadas;
            set => tamadas =tamadas+5;
        }

        public int Vedekezes
        {
            get => vedekezes;
            set => vedekezes = vedekezes+5;
        }

        public int Maxhap
        {
            get => maxhap;
            set => maxhap = maxhap+5;
        }
        
    }
}