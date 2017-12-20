using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoTG
{
    class Order : Card
    {
        public Order(string myName, string myDescription, int myTier, string myFaction, string myColor, int myCost)
            : base(myName, myDescription, myTier, myFaction, myColor, myCost)
        {

        }
    }
}
