using System.Collections.Generic;

namespace DemoGame
{
    public class Warrior
    {
         //nev
        private string name = "Geralt";
        public string GetName
        {
            get { return name; }
        }
        //eletero
        private int health = 100;
        public int GetHealth
        {
            get { return health; }
        }
        public int SetHealth
        {
            set { health = value; }
        }
        //szint
        private int level = 1;
        public int GetLevel
        {
            get { return level; }
        }
        public int SetLevel
        {
            set { level = value; }
        }
        //tapasztalatpont
        private int experience = 0;
        public int GetExperience
        {
            get { return experience; }
        }
        public int SetExperience
        {
            set { experience = value; }
        }
        //penz
        private int money = 0;
        public int GetMoney
        {
            get { return money; }
        }
        public int SetMoney
        {
            set { money = value; }
        }
        //osztaly
        private string @class = "warrior";
        public string GetClass
        {
            get { return @class; }
        }
        //inventory
        private int[] inventory;
        public int[] GetInventory
        {
            get { return inventory; }
        }
        public int[] SetInventory
        {
            set { inventory = value; }
        }
        //skill
        private Dictionary<string, bool> skill;
        public Dictionary<string, bool> GetSkill
        {
            get { return skill; }
        }
        public Dictionary<string, bool> SetSkill
        {
            set { skill = value; }
        }
        //location

        //basic attack 1
        private int basicAttack1;
        public int GetBasicAttack1
        {
            get { return basicAttack1; }
        }
        public int SetBasicAttack1
        {
            set { basicAttack1 = value; }
        }
        //basic attack 2
        private int basicAttack2;
        public int GetBasicAttack2
        {
            get { return basicAttack2; }
        }
        public int SetBasicAttack2
        {
            set { basicAttack2 = value; }
        }
        //basic attack 3
        private int basicAttack3;
        public int GetBasicAttack3
        {
            get { return basicAttack3; }
        }
        public int SetBasicAttack3
        {
            set { basicAttack3 = value; }
        }
        //defence
        private int defence=0;
        public int GetDefence
        {
            get { return defence; }
        }
        public int SetDefence
        {
            set { defence = value; }
        }
    }
}