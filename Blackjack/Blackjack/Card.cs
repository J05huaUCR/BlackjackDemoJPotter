using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    
    class Card
    {
        // Internal Properties
        private int DeckID = 0;
        private CardIDs CardID = CardIDs.C2;
        private string CardKey = "";
        private int CardValue = 0; // Numeric Value of Card
        private Suits CardSuit = Suits.CLUBS;
        private string CardFace = "";
        

        public Card() { }

        public Card(int deckID = 0, CardIDs cardID = CardIDs.C2)
        {
            
            string cardKey = Enum.GetName(typeof(CardIDs), cardID).ToString();
            int cardValue = (int)Enum.Parse(typeof(FaceValues), cardKey);


            // Determine Suit and card
            string whichSuit = cardKey.Substring(0, 1);
            switch (whichSuit)
            {
                case "H":
                    setCardSuit(Suits.HEARTS);
                    break;

                case "D":
                    setCardSuit(Suits.DIAMONDS);
                    break;

                case "C":
                    setCardSuit(Suits.CLUBS);
                    break;

                case "S":
                    setCardSuit(Suits.SPADES);
                    break;

                default:
                    setCardSuit(Suits.HEARTS);
                    break;

            }

            string whichCard = cardKey.Substring(1, 1);


            setDeckID(deckID);
            setCardID(cardID);
            setCardKey(cardKey);
            setCardValue(cardValue);
            setCardFace(whichCard);
        }

        public string getCardKey()
        {
            return CardKey;
        }

        public void setCardKey(string key)
        {
            CardKey = key;
        }

        public int getCardValue()
        {
            return CardValue;
        }

        public void setCardValue(int cv)
        {
            CardValue = cv;
        }

        public Suits getCardSuit()
        {
            return CardSuit;
        }

        public void setCardSuit(Suits s)
        {
            CardSuit = s;
        }

        public string getCardFace()
        {
            return CardFace;
        }

        public void setCardFace(string c)
        {
            CardFace = c;
        }

        private void setDeckID(int id)
        {
            DeckID = id;
        }

        public int getDeckID()
        {
            return DeckID;
        }

        private void setCardID(CardIDs cid)
        {
            CardID = cid;
        }

        public CardIDs getCardID()
        {
            return CardID;
        }
    }
}
