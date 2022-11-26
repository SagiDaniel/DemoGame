using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medievalWars
{
    internal class PassiveNPC
    {
        private string name = "Bótos";
        private int prices;
        private int items;
        public string Name
        {
            get { return name; }
        }
        public string Items
        {
            get { return items=>prices}
        }
    }
}
