using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Blackjack
{
    // The suits in the deck
    public enum Suits {
        HEARTS,
        DIAMONDS,
        SPADES,
        CLUBS
    }

    // The card value for that ID
    public enum CardIDs
    {
        C2, C3, C4, C5, C6, C7, C8, C9, C0, CJ, CQ, CK, CA,
        D2, D3, D4, D5, D6, D7, D8, D9, D0, DJ, DQ, DK, DA,
        H2, H3, H4, H5, H6, H7, H8, H9, H0, HJ, HQ, HK, HA,
        S2, S3, S4, S5, S6, S7, S8, S9, S0, SJ, SQ, SK, SA
    }

    // The Sard value for that ID
    public enum FaceValues
    {
        CA = 11, C2 = 2, C3 = 3, C4 = 4, C5 = 5, C6 = 6, C7 = 7, C8 = 8, C9 = 9, C0 = 10, CJ = 10, CQ = 10, CK = 10,
        DA = 11, D2 = 2, D3 = 3, D4 = 4, D5 = 5, D6 = 6, D7 = 7, D8 = 8, D9 = 9, D0 = 10, DJ = 10, DQ = 10, DK = 10,
        HA = 11, H2 = 2, H3 = 3, H4 = 4, H5 = 5, H6 = 6, H7 = 7, H8 = 8, H9 = 9, H0 = 10, HJ = 10, HQ = 10, HK = 10,
        SA = 11, S2 = 2, S3 = 3, S4 = 4, S5 = 5, S6 = 6, S7 = 7, S8 = 8, S9 = 9, S0 = 10, SJ = 10, SQ = 10, SK = 10
    }

    // Holds the X-coordinate for the card in the Deck image
    public enum ImageX
    {
        C2 = 0, C3 = -143, C4 = -287, C5 = -430, C6 = -574, C7 = -717, C8 = -861, C9 = -1004, C0 = -1148,
        CJ = -1291, CQ = -1435, CK = -1579, CA = -1722
    }

    // Holdes the Y-coordinate for the card in the Deck image
    public enum ImageY
    {
        H = 0, D = -210, C = -420, S = -630
    }

    class CardValues {

        public CardValues()
        {
            // Not used
        }

    }
}
