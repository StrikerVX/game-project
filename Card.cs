using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoTG
{
    class Card
    {
        private string name;
        private string description;
        private int tier;
        private string faction;
        private string color; //temporary
        private int cost;
        public Card(string myName, string myDescription, int myTier, string myFaction, string myColor, int myCost)
        {
            name = myName;
            description = myDescription;
            tier = myTier;
            faction = myFaction;
            color = myColor;
            cost = myCost;
        }
    }
}
