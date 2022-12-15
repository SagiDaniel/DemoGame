using System;
using System.Data;
using System.Xml.XPath;
using DemoGame;

namespace DemoGame
{
    public class map
    {
        public static string[] palya = new string[9];
        public static void maps(string bekerkarakter)
        {
            
            for (int i = 0; i < palya.Length; i++)
            {
                if (i==2)
                {
                    palya[i] = "X";
                }
                else if (i==6)
                {
                    palya[i] = "Y";
                }
                else
                {
                    palya[i] = "_";
                }

                if (i==0||i==8)
                {
                    palya[i] = "|";
                }
            }

            for (int i = 0; i < palya.Length; i++)
            {
                Console.Write(palya[i]);
            }
            moving.move(bekerkarakter);
        }
    }
}