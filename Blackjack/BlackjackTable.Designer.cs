namespace Blackjack
{
    partial class BlackjackTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusCardsRemaining = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusScores = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameMenuAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.gameMenuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.gameMenuDeal = new System.Windows.Forms.ToolStripMenuItem();
            this.gameMenuStand = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuIExit = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameStatusBox = new System.Windows.Forms.RichTextBox();
            this.newUser = new System.Windows.Forms.Panel();
            this.playerNameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newUserButton = new System.Windows.Forms.Button();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.lblDealer = new System.Windows.Forms.Label();
            this.statusBar.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.newUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusCardsRemaining,
            this.statusScores});
            this.statusBar.Location = new System.Drawing.Point(0, 707);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1008, 22);
            this.statusBar.TabIndex = 0;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusCardsRemaining
            // 
            this.statusCardsRemaining.BackColor = System.Drawing.Color.Transparent;
            this.statusCardsRemaining.Name = "statusCardsRemaining";
            this.statusCardsRemaining.Size = new System.Drawing.Size(75, 17);
            this.statusCardsRemaining.Text = "Dealer Score:";
            // 
            // statusScores
            // 
            this.statusScores.BackColor = System.Drawing.Color.Transparent;
            this.statusScores.Name = "statusScores";
            this.statusScores.Size = new System.Drawing.Size(83, 17);
            this.statusScores.Text = "Player 1 Score:";
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1008, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "mainMenu";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameMenuAddUser,
            this.gameMenuItemNew,
            this.gameMenuDeal,
            this.gameMenuStand,
            this.toolStripMenuIExit});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "&Game";
            // 
            // gameMenuAddUser
            // 
            this.gameMenuAddUser.Name = "gameMenuAddUser";
            this.gameMenuAddUser.Size = new System.Drawing.Size(122, 22);
            this.gameMenuAddUser.Text = "Add &User";
            this.gameMenuAddUser.Click += new System.EventHandler(this.gameMenuAddUser_Click);
            // 
            // gameMenuItemNew
            // 
            this.gameMenuItemNew.Enabled = false;
            this.gameMenuItemNew.Name = "gameMenuItemNew";
            this.gameMenuItemNew.Size = new System.Drawing.Size(122, 22);
            this.gameMenuItemNew.Text = "&New";
            this.gameMenuItemNew.Click += new System.EventHandler(this.gameMenuNew_Click);
            // 
            // gameMenuDeal
            // 
            this.gameMenuDeal.Enabled = false;
            this.gameMenuDeal.Name = "gameMenuDeal";
            this.gameMenuDeal.Size = new System.Drawing.Size(122, 22);
            this.gameMenuDeal.Text = "&Hit";
            this.gameMenuDeal.Click += new System.EventHandler(this.gameMenuDeal_Click);
            // 
            // gameMenuStand
            // 
            this.gameMenuStand.Enabled = false;
            this.gameMenuStand.Name = "gameMenuStand";
            this.gameMenuStand.Size = new System.Drawing.Size(122, 22);
            this.gameMenuStand.Text = "&Stand";
            this.gameMenuStand.Click += new System.EventHandler(this.gameMenuStand_Click);
            // 
            // toolStripMenuIExit
            // 
            this.toolStripMenuIExit.Name = "toolStripMenuIExit";
            this.toolStripMenuIExit.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuIExit.Text = "E&xit";
            this.toolStripMenuIExit.Click += new System.EventHandler(this.gameMenuExit_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameStatusToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // gameStatusToolStripMenuItem
            // 
            this.gameStatusToolStripMenuItem.CheckOnClick = true;
            this.gameStatusToolStripMenuItem.Name = "gameStatusToolStripMenuItem";
            this.gameStatusToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.gameStatusToolStripMenuItem.Text = "Game Status";
            this.gameStatusToolStripMenuItem.Click += new System.EventHandler(this.gameStatusToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.aboutToolStripMenuItem_MouseUp);
            // 
            // gameStatusBox
            // 
            this.gameStatusBox.Location = new System.Drawing.Point(774, 27);
            this.gameStatusBox.Name = "gameStatusBox";
            this.gameStatusBox.Size = new System.Drawing.Size(234, 265);
            this.gameStatusBox.TabIndex = 3;
            this.gameStatusBox.Text = "\"(none)\"";
            // 
            // newUser
            // 
            this.newUser.BackColor = System.Drawing.SystemColors.Window;
            this.newUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newUser.Controls.Add(this.playerNameTB);
            this.newUser.Controls.Add(this.label1);
            this.newUser.Controls.Add(this.newUserButton);
            this.newUser.Location = new System.Drawing.Point(26, 55);
            this.newUser.Name = "newUser";
            this.newUser.Size = new System.Drawing.Size(222, 90);
            this.newUser.TabIndex = 4;
            // 
            // playerNameTB
            // 
            this.playerNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNameTB.Location = new System.Drawing.Point(8, 27);
            this.playerNameTB.Name = "playerNameTB";
            this.playerNameTB.Size = new System.Drawing.Size(202, 26);
            this.playerNameTB.TabIndex = 2;
            this.playerNameTB.TextChanged += new System.EventHandler(this.playerNameTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input Name of Player:";
            // 
            // newUserButton
            // 
            this.newUserButton.Location = new System.Drawing.Point(70, 59);
            this.newUserButton.Name = "newUserButton";
            this.newUserButton.Size = new System.Drawing.Size(75, 23);
            this.newUserButton.TabIndex = 0;
            this.newUserButton.Text = "Add Player";
            this.newUserButton.UseVisualStyleBackColor = true;
            this.newUserButton.Click += new System.EventHandler(this.newUserButton_Click);
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.ForeColor = System.Drawing.Color.White;
            this.lblPlayer.Location = new System.Drawing.Point(459, 366);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(112, 37);
            this.lblPlayer.TabIndex = 5;
            this.lblPlayer.Text = "Player";
            this.lblPlayer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnHit
            // 
            this.btnHit.Enabled = false;
            this.btnHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.Location = new System.Drawing.Point(799, 366);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(75, 37);
            this.btnHit.TabIndex = 6;
            this.btnHit.Text = "Hit me!";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStand
            // 
            this.btnStand.Enabled = false;
            this.btnStand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStand.Location = new System.Drawing.Point(881, 366);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(75, 37);
            this.btnStand.TabIndex = 7;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = true;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // lblDealer
            // 
            this.lblDealer.AutoSize = true;
            this.lblDealer.BackColor = System.Drawing.Color.Transparent;
            this.lblDealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealer.ForeColor = System.Drawing.Color.White;
            this.lblDealer.Location = new System.Drawing.Point(459, 33);
            this.lblDealer.Name = "lblDealer";
            this.lblDealer.Size = new System.Drawing.Size(116, 37);
            this.lblDealer.TabIndex = 8;
            this.lblDealer.Text = "Dealer";
            // 
            // BlackjackTable
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::Blackjack.Properties.Resources.Felt;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.lblDealer);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.newUser);
            this.Controls.Add(this.gameStatusBox);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "BlackjackTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Joshua Potter Blackjack";
            this.Load += new System.EventHandler(this.BlackjackTable_Load);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.newUser.ResumeLayout(false);
            this.newUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        /*
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label deckLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripDealerScore;
        private System.Windows.Forms.ToolStripStatusLabel toolStripPlayerScore;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.ToolStripMenuItem dealToolStripMenuItem;
        */
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameMenuItemNew;
        private System.Windows.Forms.ToolStripMenuItem gameMenuAddUser;
        private System.Windows.Forms.ToolStripMenuItem gameMenuDeal;
        private System.Windows.Forms.ToolStripMenuItem gameMenuStand;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuIExit;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel statusCardsRemaining;
        private System.Windows.Forms.ToolStripStatusLabel statusScores;
        private System.Windows.Forms.RichTextBox gameStatusBox;
        private System.Windows.Forms.Panel newUser;
        private System.Windows.Forms.TextBox playerNameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newUserButton;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameStatusToolStripMenuItem;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.Label lblDealer;
    }
}

