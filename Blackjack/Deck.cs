using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
 

    class Deck
    {
        public Deck(int id = 65535) {
            Console.WriteLine("Deck instantiated.");
            setID(id);
            build();
        }

        private void setID(int id)
        {
            ID = id;
        }

        public int getID()
        {
            return ID;
        }

        public void build()
        {
            // Traverse CardIDs enum to create each card
            CardIDs cardID;
            
            foreach (var card in Enum.GetNames(typeof(CardIDs)))
            {
                cardID = (CardIDs)Enum.Parse(typeof(CardIDs), card);

                // Instantiate Card DeckID, CardID
                Card c = new Card(getID(), cardID);

                // Add
                TempDeck.Add(c);
            }

        }

        public void shuffle() {

            Card c;

            // Return remaining cards to Deck
            while (DealDeck.Count > 0)
            {
                c = DealDeck.Dequeue();
                TempDeck.Add(c);
            }

            // Get random cards and place in Queue
            Random rnd = new Random();
            int i = 0;
            while (TempDeck.Count() > 0)
            {
                // Get random number between 0 and InternalDeck size
                rnd = new Random();
                i = rnd.Next(0, TempDeck.Count());

                // Retrieve card from that location and place in DealPile
                DealDeck.Enqueue(TempDeck.ElementAt(i));

                // Remove from InternalDeck
                TempDeck.RemoveAt(i);
            }
        }

        public Card deal()
        {
            return DealDeck.Dequeue();
        }

        public void replace(Card c)
        {
            TempDeck.Add(c);
        }

        public int getCardsRemaining()
        {
            return DealDeck.Count();
        }

        
        private int ID = 65535;
        private Queue<Card> DealDeck = new Queue<Card>();
        private List<Card> TempDeck = new List<Card>();

    }
}
