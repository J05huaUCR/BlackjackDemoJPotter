using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Config
    {
        /* Repository for UI Parameters */
        public string Attribution = "Blackjack Demo coded by Joshua Potter 2022.";
        public string DealerName = "Dealer";
        public string PlayerName = "Player";
        public string MsgWin = " WINS!!";
        public string MsgTie = " tied.";
        public string ErrorBadName = "INVALID! Please try again...";

        public int MaxPlayers = 2; // Including Dealer
        public int ShoeSize = 1; // Number of Decks in Shoe
        public int DealerStandScore = 17; // Dealer Stand here or higher
        public int ErrorValue = 65535;
    }
}
