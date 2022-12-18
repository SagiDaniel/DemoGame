using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGame
{
    public class Item
    {
        //healek
        private int Bandage;
        public int GetBandage => Bandage;
        private int Poti;
        public int GetPoti => Poti;
        private int Medkit;
        public int GetMedkit => Medkit;
        private int Jugjug;

        public int GetJugjug => Jugjug;

        //Armor
        private int head;
        public int GetHead => head;
        private int stomach;
        public int GetStomach => stomach;
        private int legs;

        public int GetLegs => legs;

        //move
        private int shoes;
        public int GetShoes => shoes;
    }
}