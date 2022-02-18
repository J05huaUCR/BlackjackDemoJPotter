using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    
    public partial class BlackjackTable : Form
    {
        private Game blackJack;
        public Dictionary<string, Panel> DeckUI = new Dictionary<string, Panel>();
        int cardWidth = 144;
        Point dealerOrigin = new Point(80, 100);
        Point playerOrigin = new Point(80, 436);
        Config cfg = new Config();

        public BlackjackTable()
        {
            InitializeComponent();
            
            blackJack = new Game();
            gameStatusBox.Visible = false;
            gameStatusBox.Text = blackJack.getInfo();
            newUser.Visible = false;
            renderDeck();
            showDeck(false);
            updateUI();
        }

        // Renders card deck to UI
        public void renderDeck()
        {

            string cardID = "";
            Point p = new Point(0,0);

            // Traverse CardIDs enum to get image coordinates
            foreach (var card in Enum.GetNames(typeof(CardIDs)))
            {
                // Get enum ID
                cardID = card.ToString();

                // Which suit
                string whichRow = cardID.Substring(0, 1);
                switch (whichRow)
                {
                    case "H":
                        p.Y = (int)ImageY.H;
                        break;

                    case "D":
                        p.Y = (int)ImageY.D;
                        break;

                    case "C":
                        p.Y = (int)ImageY.C;
                        break;

                    case "S":
                        p.Y = (int)ImageY.S;
                        break;

                    default:
                        // Nothing
                        break;

                }

                // Which Card
                string whichCol = cardID.Substring(1, 1);
                switch (whichCol)
                { 
                    case "2":
                        p.X = (int)ImageX.C2;
                        break;
                    case "3":
                        p.X = (int)ImageX.C3;
                        break;
                    case "41":
                        p.X = (int)ImageX.C4;
                        break;
                    case "5":
                        p.X = (int)ImageX.C5;
                        break;
                    case "6":
                        p.X = (int)ImageX.C6;
                        break;
                    case "7":
                        p.X = (int)ImageX.C7;
                        break;
                    case "8":
                        p.X = (int)ImageX.C8;
                        break;
                    case "9":
                        p.X = (int)ImageX.C9;
                        break;
                    case "0":
                        p.X = (int)ImageX.C0;
                        break;
                    case "J":
                        p.X = (int)ImageX.CJ;
                        break;
                    case "Q":
                        p.X = (int)ImageX.CQ;
                        break;
                    case "K":
                        p.X = (int)ImageX.CK;
                        break;
                    case "A":
                        p.X = (int)ImageX.CA;
                        break;

                    default:
                        // Nothing
                        break;

                }

                Panel pnl = new Panel();
                pnl.Visible = true;
                pnl.Size = new Size(143, 209);
                pnl.Location = p;
                pnl.BorderStyle = BorderStyle.None;
                pnl.BackColor = Color.Transparent;

                PictureBox pic = new PictureBox();
                pic.Location = p;
                pic.Size = new Size(1866, 840);
                pic.BackgroundImage = Properties.Resources.Deck_s;
                pic.BackgroundImageLayout = ImageLayout.None;
                pic.SizeMode = PictureBoxSizeMode.Normal;
                pnl.Controls.Add(pic);
                this.Controls.Add(pnl);

                // Add to Deck
                DeckUI.Add(cardID, pnl);
            }

            resetDeck();            
        }

        private void resetDeck()
        {
            Panel p;
            Point pt = new Point(0, 300);
            int i = 1014;
            foreach (var item in DeckUI)
            {
                pt.X = i;
                
                p = item.Value;
                p.Location = pt;
                i -= 20;
            }
        }

        private void showDeck(bool b)
        {
            Panel p;
            foreach (var item in DeckUI)
            {
                p = item.Value;
                p.Visible = b;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void BlackjackTable_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_MouseUp(object sender, MouseEventArgs e)
        {
            showAboutBox();
        }
        

        public void showAboutBox()
        {
            MessageBox.Show(cfg.Attribution);
        }

        private void playerNameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void enableGameMenu(bool b)
        {
            gameMenuDeal.Enabled = b;
            gameMenuStand.Enabled = b;
            btnHit.Enabled = b;
            btnStand.Enabled = b;
        }

        private void newUserButton_Click(object sender, EventArgs e)
        {
            if (playerNameTB.Text != "")
            {
                blackJack.addPlayer(playerNameTB.Text);
                newUser.Visible = false;
                gameMenuAddUser.Enabled = false;
                gameMenuItemNew.Enabled = true;
                updateUI();
            } else
            {
                playerNameTB.Text = cfg.ErrorBadName;
            }
        }

        private void gameStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Toggle Visibility
            gameStatusToolStripMenuItem.Checked = !gameStatusBox.Visible;
            gameStatusBox.Visible = !gameStatusBox.Visible;
        }

        private void gameMenuExit_Click(object sender, EventArgs e)
        {
            if (blackJack.getState() == GameStates.PLAYER_TURN || blackJack.getState() == GameStates.DEALER_TURN)
            {
                // Game not finished
                MessageBox.Show("Game not over!");
            }
            else
            {
                this.Close();
            }
        }

        private void gameMenuAddUser_Click(object sender, EventArgs e)
        {
            if (blackJack.getPlayerCount() < 2)
            {
                newUser.Visible = true;
            }
        }

        private void gameMenuNew_Click(object sender, EventArgs e)
        {
            enableGameMenu(true);
            blackJack.start();
            updateUI();
        }

        private void gameMenuDeal_Click(object sender, EventArgs e)
        {
            blackJack.deal(1);
            updateUI();
        }

        private void gameMenuStand_Click(object sender, EventArgs e)
        {
            blackJack.stand();
            updateUI();
            
        }

        private void setStatusBar()
        {

            string status = "";
            int cardsLeft = 0;
            string dealerName = cfg.DealerName;
            int dealerScore = 0;
            string playerName = cfg.PlayerName;
            int playerScore = 0;


            // Assignments
            cardsLeft = blackJack.getCardsRemaining();
            if (blackJack.getPlayerCount() > 0)
            {
                dealerName = blackJack.getPlayerName(0);
                dealerScore = blackJack.getPlayerScore(0);
            }

            if (blackJack.getPlayerCount() > 1)
            {
                playerName = blackJack.getPlayerName(1);
                playerScore = blackJack.getPlayerScore(1);
            }

            statusCardsRemaining.Text = "Cards remaining: " + cardsLeft.ToString();
            status += "Scores: ";
            status += dealerName + " has " + blackJack.getPlayerScore(0).ToString() + ", ";
            status += playerName + " has " + playerScore.ToString();
            statusScores.Text = status;
        }

        private void renderHands()
        {

            List<CardIDs> dealerHand;
            List<CardIDs> playerHand;
            Panel pnl;
            string whichCard = "";

            // Process Dealer Hand
            dealerHand = blackJack.getHand(0);
            for (int i = 0; i < dealerHand.Count(); i++)
            {
                whichCard = dealerHand[i].ToString();
                pnl = DeckUI[whichCard];
                pnl.Visible = true;
                pnl.Location = new Point(dealerOrigin.X + (cardWidth * i), dealerOrigin.Y);
            }

            // Process Player hands
            playerHand = blackJack.getHand(1);
            for (int i = 0; i < playerHand.Count(); i++)
            {
                whichCard = playerHand[i].ToString();
                pnl = DeckUI[whichCard];
                pnl.Visible = true;
                pnl.Location = new Point(playerOrigin.X + (cardWidth * i), playerOrigin.Y);
            }
        }

        // Render UI based on game state
        public void updateUI()
        {

            switch ( blackJack.getState() )
            {

                case GameStates.INIT:
                    showDeck(false);
                    break;

                case GameStates.ADD_PLAYER:
                    showDeck(false);
                    break;

                case GameStates.START:
                    lblDealer.Text = blackJack.getPlayerName(0);
                    lblPlayer.Text = blackJack.getPlayerName(1);
                    
                    gameStatusBox.Text = blackJack.getInfo();
                    showDeck(false);
                    renderHands();
                    break;

                case GameStates.DEAL:
                    
                    showDeck(false);
                    renderHands();
                    break;

                case GameStates.PLAYER_TURN:
                    lblDealer.Text = blackJack.getPlayerName(0);
                    lblPlayer.Text = blackJack.getPlayerName(1);
                    showDeck(false);
                    renderHands();
                    break;

                case GameStates.DEALER_TURN:
                    enableGameMenu(false);
                    renderHands();
                    break;

                case GameStates.PLAYER_WIN:
                    lblPlayer.Text = blackJack.getPlayerName(1) + cfg.MsgWin;
                    enableGameMenu(false);
                    renderHands();
                    break;

                case GameStates.DEALER_WIN:
                    lblDealer.Text = blackJack.getPlayerName(0) + cfg.MsgWin;
                    enableGameMenu(false);
                    renderHands();
                    break;

                case GameStates.TIE:
                    lblPlayer.Text = blackJack.getPlayerName(1) + cfg.MsgTie;
                    renderHands();
                    break;

                default:
                    // Do nothing
                    break;
                    
            }
            setStatusBar();
            gameStatusBox.Text = blackJack.getInfo();
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            blackJack.deal(1);
            updateUI();
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            blackJack.stand();
            enableGameMenu(false);
            updateUI();
        }
    }
    
    
}
