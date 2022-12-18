using System;
using System.Configuration;
using System.Data;
using System.Xml.XPath;
using DemoGame;

namespace DemoGame
{
    public class player
    {
        /*karakter:
         eletero
         szint
         tapasztalatpont
         penz
         bas atc1
         bas atc2
         bas atc3
         defens
         */
        /*inv:
         Bandagee
         Poti
         Medkit
         Jugjug
         head
         stromach
         legs
         shoes
         */
        /*skill
         tamadas
         vedeketzes
         maxhp
         */
        public static int[] jatekos = new int[8];
        public static int[] inv = new int[8];

        public static void karakter(string bekerkarakter)
        {
            if ("fiora" == bekerkarakter)
            {
                Wizard seged = new Wizard();
                jatekos[0] = seged.GetHealth;
                jatekos[1] = seged.GetLevel;
                jatekos[2] = seged.GetExperience;
                jatekos[3] = seged.GetMoney;
                jatekos[4] = seged.GetBasicAttack1;
                jatekos[5] = seged.GetBasicAttack2;
                jatekos[6] = seged.GetBasicAttack3;
                jatekos[7] = seged.GetDefence;
            }
            else if ("hawk" == bekerkarakter)
            {
                Warrior seged = new Warrior();
                jatekos[0] = seged.GetHealth;
                jatekos[1] = seged.GetLevel;
                jatekos[2] = seged.GetExperience;
                jatekos[3] = seged.GetMoney;
                jatekos[4] = seged.GetBasicAttack1;
                jatekos[5] = seged.GetBasicAttack2;
                jatekos[6] = seged.GetBasicAttack3;
                jatekos[7] = seged.GetDefence;
            }
            else if ("geralt" == bekerkarakter)
            {
                Archer seged = new Archer();
                jatekos[0] = seged.GetHealth;
                jatekos[1] = seged.GetLevel;
                jatekos[2] = seged.GetExperience;
                jatekos[3] = seged.GetMoney;
                jatekos[4] = seged.GetBasicAttack1;
                jatekos[5] = seged.GetBasicAttack2;
                jatekos[6] = seged.GetBasicAttack3;
                jatekos[7] = seged.GetDefence;
            }

            Item inventory = new Item();
            inv[0] = inventory.GetBandage;
            inv[1] = inventory.GetPoti;
            inv[2] = inventory.GetMedkit;
            inv[3] = inventory.GetJugjug;
            inv[4] = inventory.GetHead;
            inv[5] = inventory.GetStomach;
            inv[6] = inventory.GetLegs;
            inv[7] = inventory.GetShoes;
        }
    }
}