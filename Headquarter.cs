using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoTG
{
    class Headquarter : Unit
    {
        private int baseHealth;
        private int baseAttack;
        private int attackModifier;
        private int healthModifier;
        private int resourceGain;
        private string mastery;
        public Headquarter(string myName, string myDescription, int myTier, string myFaction, string myColor, int myCost, int myHealth, int myAttack, int myResourceGain, string myMastery)
            : base(myName, myDescription, myTier, myFaction, myColor, myCost, myHealth, myAttack, myResourceGain)
        {
            baseHealth = myHealth;
            baseAttack = myAttack;
            resourceGain = myResourceGain;
            mastery = myMastery;
        } 
    }
}
