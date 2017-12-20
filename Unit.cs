using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoTG
{
    class Unit : Card
    {
        private int baseHealth;
        private int baseAttack;
        private int attackModifier;
        private int healthModifier;
        private int resourceGain;
        public Unit(string myName, string myDescription, int myTier, string myFaction, string myColor, int myCost, int myHealth, int myAttack, int myResourceGain)
            : base(myName,  myDescription, myTier, myFaction, myColor, myCost)
        {
            baseHealth = myHealth;
            baseAttack = myAttack;
            resourceGain = myResourceGain;
        }
    }
}
