using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoTG
{

    class Player
    {
        private string ID;
        private string nickname;
        private Collection myCollection;
        private Deck[] myDecks;
        //private Hand myHand;
        public Player(string playerID, string playernickname)
        {
            ID = playerID;
            nickname = playernickname;
            myCollection = new Collection();
            myDecks = new Deck[10];
            //myHand = new Hand();
        }
        public string getID()
        {
            return ID;
        }
        public string getNickname()
        {
            return nickname;
        }
        public Deck[] getDeck()
        {
            return myDecks;
        }
    }
}
