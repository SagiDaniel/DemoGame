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
            private int Bandage = 15;

            public int GetBandage => Bandage;

            private int Poti = 5;
            public int GetPoti => Poti;
            private int Medkit = 50;
            public int GetMedkit=> Medkit;
            private int Jugjug = 75;
            public int GetJugjug => Jugjug;
        
            //Armor
            private int head = 40;

            public int GetHead => head;
            private int stomach = 40;

            public int GetStomach => stomach;
            private int legs = 20;

            public int GetLegs => legs;
            //move
            private int shoes = 2;
            public int GetShoes => shoes;
    }
}