using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medievalWars
{
    internal class Wizard
    {
        private string name = "Fiona";
        private int health;
        private int level;
        private int experience;
        private int money;
        private string @class = "wizard";

        public string Name
        {
            get { return name; }
        }

        public int Health
        {
            get { return health; }
        }

        public int Level
        {
            get { return level; }
        }

        public int Experience
        {
            get { return experience; }
        }

        public int Money
        {
            get { return money; }
        }

        public string Class
        {
            get { return @class; }
        }
    }
}
