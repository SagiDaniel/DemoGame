using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGame
{
    class Wizard
    {
        //nev
        private string name = "Fiona";
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
        //szint
        private int level = 1;
        public int GetLevel
        {
            get { return level; }
        }
        public void Levelup()
        {
            level++;
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
            get => basicAttack1;
            set => basicAttack1 = value;
        }
        //basic attack 2
        private int basicAttack2;

        public int GetBasicAttack2
        {
            get => basicAttack2;
            set => basicAttack2 = value;
        }

        //basic attack 3
        private int basicAttack3;

        public int GetBasicAttack3
        {
            get => basicAttack3;
            set => basicAttack3 = value;
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
