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

        public BlackjackTable()
        {
            InitializeComponent();
            
            blackJack = new Game();
            gameStatusBox.Visible = false;
            gameStatusBox.Text = blackJack.getInfo();
            newUser.Visible = false;

            /*
            Panel dynamicPanel = new Panel();
            dynamicPanel.Visible = true;
            dynamicPanel.Location = new Point(50, 50);
            dynamicPanel.Name = "Panel1";
            dynamicPanel.Size = new Size(228, 200);
            dynamicPanel.BackColor = Color.Transparent;
            dynamicPanel.BackgroundImage = Properties.Resources.C2s;
            dynamicPanel.BackgroundImageLayout = ImageLayout.Zoom;
            TextBox textBox1 = new TextBox();
            textBox1.Location = new Point(10, 10);
            textBox1.Text = "I am a TextBox5";
            textBox1.Size = new Size(200, 30);
            CheckBox checkBox1 = new CheckBox();
            checkBox1.Location = new Point(10, 50);
            checkBox1.Text = "Check Me";
            checkBox1.Size = new Size(200, 30);
            dynamicPanel.Controls.Add(textBox1);
            dynamicPanel.Controls.Add(checkBox1);
            Controls.Add(dynamicPanel);
            

            Panel pnl1 = new Panel();
            pnl1.Visible = true;
           // Color w = new Color();
            //w = Color.FromArgb(125, 125, 125, 125);
            pnl1.Size = new Size(143, 209);
            pnl1.Location = new Point(300, 450);
            pnl1.BorderStyle = BorderStyle.None;
            pnl1.BackColor = Color.Transparent;

            PictureBox pic = new PictureBox();
            pic.Location = new Point((int)ImageX.C1, (int)ImageY.C);
            pic.Size = new Size(1866, 840);
            pic.BackgroundImage = Properties.Resources.Deck_s;
            pic.BackgroundImageLayout = ImageLayout.None;
            pic.SizeMode = PictureBoxSizeMode.Normal;
            pnl1.Controls.Add(pic);
            this.Controls.Add(pnl1);

            Panel pnl2 = new Panel();
            pnl2.Visible = true;
            pnl2.Size = new Size(143, 209);
            pnl2.Location = new Point(443, 450);
            pnl2.BorderStyle = BorderStyle.None;
            pnl2.BackColor = Color.Transparent;

            PictureBox pic2 = new PictureBox();
            pic2.Location = new Point((int)ImageX.CA, (int)ImageY.S);
            pic2.Size = new Size(1866, 840);
            pic2.BackgroundImage = Properties.Resources.Deck_s;
            pic2.BackgroundImageLayout = ImageLayout.None;
            pic2.SizeMode = PictureBoxSizeMode.Normal;
            pnl2.Controls.Add(pic2);
            this.Controls.Add(pnl2);
            */

            /*
            this.card0.BackColor = System.Drawing.Color.Transparent;
            this.card0.BackgroundImage = global::Blackjack.Properties.Resources.C2s;
            this.card0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.card0.Location = new System.Drawing.Point(390, 318);
            this.card0.Name = "card0";
            this.card0.Size = new System.Drawing.Size(134, 200);
            this.card0.TabIndex = 2;
            this.card0.MouseEnter += new System.EventHandler(this.card0_MouseEnter);
            this.card0.MouseLeave += new System.EventHandler(this.card0_MouseLeave);
            */
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
                string whichCol = cardID.Substring(1, cardID.Length - 1);
                switch (whichCol)
                {
                    case "10":
                        p.X = (int)ImageX.C10;
                        break;
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
            MessageBox.Show("Blackjack Demo coded by Joshua Potter 2022.");
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
                playerNameTB.Text = "Invalid! Try again!";
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
            
            blackJack.start();
            enableGameMenu(true);
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
            string dealerName = "<Dealer>";
            int dealerScore = 0;
            string playerName = "<player>";
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
            Console.WriteLine("renderHands() called");
            List<CardIDs> dealerHand;
            List<CardIDs> playerHand;
            Panel pnl;
            string whichCard = "";

            // Process Dealer Hand
            dealerHand = blackJack.getHand(0);
            for (int i = 0; i < dealerHand.Count(); i++)
            {
                whichCard = dealerHand[i].ToString();
                Console.WriteLine("Dealer whichCard: {0}", whichCard);
                pnl = DeckUI[whichCard];
                pnl.Visible = true;
                pnl.Location = new Point(dealerOrigin.X + (cardWidth * i), dealerOrigin.Y);
            }

            // Process Player hands
            playerHand = blackJack.getHand(1);
            for (int i = 0; i < playerHand.Count(); i++)
            {
                whichCard = playerHand[i].ToString();
                Console.WriteLine("Player whichCard: {0}", whichCard);
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
                    Console.WriteLine("state: INIT");
                    showDeck(false);
                    break;

                case GameStates.ADD_PLAYER:
                    Console.WriteLine("state: ADD_PLAYER");
                    break;

                case GameStates.START:
                    Console.WriteLine("state: START");
                    lblPlayer.Text = blackJack.getPlayerName(1);
                    gameStatusBox.Text = blackJack.getInfo();
                    showDeck(false);
                    break;

                case GameStates.DEAL:
                    Console.WriteLine("state: DEAL");
                    renderHands();
                    break;

                case GameStates.PLAYER_TURN:
                    renderHands();
                    break;

                case GameStates.DEALER_TURN:
                    enableGameMenu(false);
                    renderHands();
                    break;

                case GameStates.PLAYER_WIN:
                    lblPlayer.Text = blackJack.getPlayerName(1) + " WINS!!!";
                    enableGameMenu(false);
                    renderHands();
                    break;

                case GameStates.DEALER_WIN:
                    lblDealer.Text = blackJack.getPlayerName(0) + " WINS!!!";
                    enableGameMenu(false);
                    renderHands();
                    break;

                case GameStates.TIE:
                    lblPlayer.Text = blackJack.getPlayerName(1) + " tied.";
                    enableGameMenu(false);
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
            blackJack.deal();
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
