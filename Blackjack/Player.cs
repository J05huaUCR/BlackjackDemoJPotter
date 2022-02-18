using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Player
    {
        // Properties
        private String Name = "";
        private int ID = 65535;
        private int Score = 0;
        private bool Dealer = false;
        public List<Card> Hand = new List<Card>();

        // Constructor
        public Player(String s = "Player 1", bool d = false, int id = 65535)
        {
            setName(s);
            isDealer(d);
            setID(id);
        }

        // Methods
        public int getScore() {
            return Score;
        }

        private void setScore(ushort s)
        {
            Score = s;
            return;
        }

        private void setID(int i)
        {
            ID = i;
        }

        public int getID()
        {
            return ID;
        }

        public void takeCard(Card c)
        {
            Hand.Add(c);
            calculateHand();
        }

        private void calculateHand()
        {
            int result = 0;
            int cardValue = 0;
            int aceCount = 0;

            // Initial Sum
            foreach (Card c in Hand)
            {
                cardValue = c.getCardValue();
                if (cardValue == 11) aceCount++; // Ace found in hand
                result += cardValue;
            }

            // If greater than 21, change any aces until either score under 21, or out of aces
            if (result > 21)
            {
                while(aceCount > 0 && result > 21)
                {
                    result -= 10;
                    aceCount--;
                }
            }
            Score = result; 
        }

        public void isDealer(bool b)
        {
            Dealer = b;
            return;
        }

        public bool isDealer()
        {
            return Dealer;
        }

        private void setName(String s)
        {
            if (s == "") s = "Player 1";
            Name = s;
        }

        public String getName()
        {
            return Name;
        }

        public String getHandAsString()
        {
            String hand = "";
            foreach(Card c in Hand)
            {
                hand += c.getCardFace() + " of " + c.getCardSuit() + ",";
            }
            return hand;
        }

        public List<CardIDs> getHand()
        {
            List<CardIDs> hand = new List<CardIDs>();
            foreach (Card c in Hand)
            {
                hand.Add(c.getCardID());
            }
            return hand;
        }

        public List<Card> returnCards()
        {
            List<Card> toss = new List<Card>();
            
            while(Hand.Count() > 0)
            {
                toss.Add(Hand.ElementAt(0));
                Hand.RemoveAt(0);
            }
            return toss;
        }
        
    }

}
