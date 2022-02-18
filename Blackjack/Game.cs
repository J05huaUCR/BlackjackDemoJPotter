using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{

    enum GameStates
    {
        INIT,
        ADD_PLAYER,
        START,
        DEAL,
        PLAYER_TURN,
        DEALER_TURN,
        TIE,
        PLAYER_WIN,
        DEALER_WIN
    }

    class Game
    {
        private GameStates State = GameStates.INIT;
        private List<Player> Players = new List<Player>();
        private List<Deck> Shoe = new List<Deck>();
        private int MaxPlayers = 2;
        private int PlayerCount = 0;
        private int DeckCount = 0;

        public Game(int deckCount = 1, int maxPlayers = 2) {
            setDeckCount(deckCount);
            init();
        }

        private void init()
        {
            setState(GameStates.INIT);

            // Populate Shoe and shuffle
            for (int i = 0; i < getDeckCount(); i++)
            {
                // Create new Deck
                Deck d = new Deck(Shoe.Count());

                // Add to Shoe
                Shoe.Add(d);
            }

            // Set up dealer
            addPlayer("Dealer", true);

            // Trigger add player
            setState(GameStates.ADD_PLAYER);

        }

        public void addPlayer(String name, bool isDealer = false)
        {
            Player p = new Player(name, isDealer, Players.Count());
            add(p);
            if ( getPlayerCount() == getMaxPlayers() ) State = GameStates.START;
        }

        private void add(Player p)
        {
            Players.Add(p);
            setPlayerCount(getPlayerCount() + 1);
            return;
        }

        public String getInfo()
        {
            String info = "";
            info += "State: ";
            info += State.ToString();
            info += "\n";
            info += "Players: \n";
            for (int i = 0; i < Players.Count(); i++)
            {
                Player p = Players[i];
                info += "\tPlayer " + (i + 1).ToString() + ": " + p.getName() + ", Score: " + p.getScore() + "\n";
                info += "\tHand: " + p.getHandAsString() + "\n";
            }
            info += "Cards emaining: " + getCardsRemaining().ToString() + "\n";
            return info;
        }

        private void setState(GameStates s)
        {
            State = s;
        }

        public GameStates getState()
        {
            return State;
        }

        public void shuffleCards()
        {
            foreach (Deck d in Shoe)
            {
                d.shuffle();
            }
        }

        public int getCardsRemaining()
        {
            int cardCount = 0;
            foreach (Deck d in Shoe)
            {
                cardCount += d.getCardsRemaining();
            }
            return cardCount;
        }

        private void setDeckCount(int d = 1)
        {
            if (d < 1) d = 1;
            DeckCount = d;
        }

        private int getDeckCount()
        {
            return DeckCount;
        }

        private void setPlayerCount(int d = 1)
        {
            if (d < 1) d = 1;
            PlayerCount = d;
        }

        public int getPlayerCount()
        {
            return PlayerCount;
        }

        private void setMaxPlayers(int m)
        {
            if (m < 2) m = 2;
            MaxPlayers = m;
        }

        private int getMaxPlayers()
        {
            return MaxPlayers;
        }

        public void start()
        {
            // Shuffle each deck in the Shoe
            shuffleCards();

            foreach (Player p in Players)
            {
                p.takeCard(Shoe.ElementAt(0).deal());
                p.takeCard(Shoe.ElementAt(0).deal());
            }
            setState(GameStates.PLAYER_TURN);
        }

        // Deal card to player
        public void deal(int playerID)
        {
            if (playerID < getPlayerCount())
            {
                Player p = Players.ElementAt(playerID);
                p.takeCard(Shoe.ElementAt(0).deal());
            }

        }

        public void deal()
        {
            if (Players.Count() > 1) { 
                Player p = Players.ElementAt(1);
                if (p.getScore() == 21)
                {
                    State = GameStates.PLAYER_WIN;

                }
                else if (p.getScore() < 21)
                {
                    p.takeCard(Shoe.ElementAt(0).deal());
                    if (p.getScore() > 21)
                    {
                        State = GameStates.DEALER_WIN;
                    }
                }
                else
                {
                    State = GameStates.DEALER_WIN;
                }
            }
        }

        public void stand()
        {
            State = GameStates.DEALER_TURN;
        }

        public string getPlayerName(int i)
        {
            string name = "<player>";
            if ( i < getPlayerCount() )
            {
                name = Players[i].getName();
            }
            return name;
        }

        public int getPlayerScore(int i)
        {
            int score = 0;
            if (i < getPlayerCount())
            {
                score = Players[i].getScore();
            }
            return score;
        }
        
        public List<CardIDs> getHand(int i)
        {
            Console.WriteLine("Game::getHand({0}) called",  i);
            if (i < getPlayerCount() )
            {
                return Players[i].getHand();
            }
            List<CardIDs> hand = new List<CardIDs>();
            return hand;
        }
    }
}
