using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class MainGameControl : UserControl
    {
        public MainGameControl()
        {
            InitializeComponent();

            Start.playerCash = 300;
        }

        Random randgen = new Random();

        Font drawFont = new Font("Arial", 12);
        SolidBrush drawBrush = new SolidBrush(Color.Black);

        Image cardDisplay, hidenCard, SplitCard;
        Image[] cardSet = new Image[52] { Properties.Resources.S14, Properties.Resources.S2, Properties.Resources.S3, Properties.Resources.S4, Properties.Resources.S5, Properties.Resources.S6, Properties.Resources.S7, Properties.Resources.S8, Properties.Resources.S9, Properties.Resources.S10, Properties.Resources.S11, Properties.Resources.S12, Properties.Resources.S13, Properties.Resources.H14, Properties.Resources.H2, Properties.Resources.H3, Properties.Resources.H4, Properties.Resources.H5, Properties.Resources.H6, Properties.Resources.H7, Properties.Resources.H8, Properties.Resources.H9, Properties.Resources.H10, Properties.Resources.H11, Properties.Resources.H12, Properties.Resources.H13, Properties.Resources.D14, Properties.Resources.D2, Properties.Resources.D3, Properties.Resources.D4, Properties.Resources.D5, Properties.Resources.D6, Properties.Resources.D7, Properties.Resources.D8, Properties.Resources.D9, Properties.Resources.D10, Properties.Resources.D11, Properties.Resources.D12, Properties.Resources.D13, Properties.Resources.C14, Properties.Resources.C2, Properties.Resources.C3, Properties.Resources.C4, Properties.Resources.C5, Properties.Resources.C6, Properties.Resources.C7, Properties.Resources.C8, Properties.Resources.C9, Properties.Resources.C10, Properties.Resources.C11, Properties.Resources.C12, Properties.Resources.C13 };
        int dealer, amount = -1, pot, dealerCardCount, currentCardCount, playerAmount;
        Boolean Player, stand = false, start = true;
        string[,] deck = new string[52, 2] { { "1", "S" }, { "2", "S" }, { "3", "S" }, { "4", "S" }, { "5", "S" }, { "6", "S" }, { "7", "S" }, { "8", "S" }, { "9", "S" }, { "10", "S" }, { "11", "S" }, { "12", "S" }, { "13", "S" }, { "1", "H" }, { "2", "H" }, { "3", "H" }, { "4", "H" }, { "5", "H" }, { "6", "H" }, { "7", "H" }, { "8", "H" }, { "9", "H" }, { "10", "H" }, { "11", "H" }, { "12", "H" }, { "13", "H" }, { "1", "D" }, { "2", "D" }, { "3", "D" }, { "4", "D" }, { "5", "D" }, { "6", "D" }, { "7", "D" }, { "8", "D" }, { "9", "D" }, { "10", "D" }, { "11", "D" }, { "12", "D" }, { "13", "D" }, { "1", "C" }, { "2", "C" }, { "3", "C" }, { "4", "C" }, { "5", "C" }, { "6", "C" }, { "7", "C" }, { "8", "C" }, { "9", "C" }, { "10", "C" }, { "11", "C" }, { "12", "C" }, { "13", "C" } };
        string[] CardsInPlay = new string[52];
        int[] playerList = new int[52];
        int[] dealerList = new int[52];

        void display()
        {
            Graphics g = this.CreateGraphics();
            potLable.Text = "Pot: " + pot;
            CashLable.Text = "Amount: " + Start.playerCash;
            Player = true;
            playerLable.Text = "Total: " + amountCount();
            this.Refresh();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (start == true)
            {
                Start.playerCash = Start.playerCash + pot;
                pot = 0;
                display();
                Refresh();
                Start.score.Add(Start.playerCash);

                Form f = this.FindForm();
                f.Controls.Remove(this);
                MainMenuContrrol ms = new MainMenuContrrol();
                f.Controls.Add(ms);
            }
        }

        private void game_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            MiniGameListControl ms = new MiniGameListControl();
            f.Controls.Add(ms);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (start == true)
            {
                resultLable.Text = "";

                Player = true;
                drawCard();
                p1.Visible = true;
                p1.Image = cardDisplay;
                Player = false;
                drawCard();
                d1.Visible = true;
                d1.Image = cardDisplay;
                Player = true;
                drawCard();
                p2.Visible = true;
                p2.Image = cardDisplay;
                Player = false;
                drawCard();
                d2.Visible = true;
                hidenCard = cardDisplay;
                d2.Image = Properties.Resources.cardBack;

                start = false;
            }
            else
            {
                button4.Visible = false;
                button3.Visible = false;
                Player = true;
                drawCard();
                // display the card as player card
                switch (amount)
                {
                    case 4:
                        p3.Visible = true;
                        p3.Image = cardDisplay;
                        break;
                    case 5:
                        p4.Visible = true;
                        p4.Image = cardDisplay;
                        break;
                    case 6:
                        p5.Visible = true;
                        p5.Image = cardDisplay;
                        break;
                    case 7:
                        p6.Visible = true;
                        p6.Image = cardDisplay;
                        break;
                    case 8:
                        p7.Visible = true;
                        p7.Image = cardDisplay;
                        break;

                }

            }

            Player = true;
            currentCardCount = amountCount();
            playerLable.Text = currentCardCount.ToString();
            display();
            end();
        }

        private void bet5_Click(object sender, EventArgs e)
        {
            if (start)
            {
                if (Start.playerCash >= 5)
                {
                    pot = pot + 5;
                    Start.playerCash = Start.playerCash - 5;
                    display();
                }
            }
        }

        private void bet50_Click(object sender, EventArgs e)
        {
            if (start)
            {
                if (Start.playerCash >= 50)
                {
                    pot = pot + 50;
                    Start.playerCash = Start.playerCash - 50;
                    display();
                }
            }
        }

        private void bet100_Click(object sender, EventArgs e)
        {
            if (start == true)
            {
                if (Start.playerCash >= 100)
                {
                    pot = pot + 100;
                    Start.playerCash = Start.playerCash - 100;
                    display();
                }
            }
        }

        void drawCard()
        {
            amount++;
            int x = randgen.Next(1, 52);
            CardsInPlay[amount] = deck[x, 1].ToString() + deck[x, 0].ToString();
            if (Player)
            {
                playerList[amount] = Convert.ToInt16(deck[x, 0]);
            }
            else
            {
                dealerList[amount] = Convert.ToInt16(deck[x, 0]);
            }

            for (int i = 0; i <= 51; i++)
            {
                if (i == amount)
                {
                    // Skip this step                    
                }
                else
                {
                    while (CardsInPlay[amount] == CardsInPlay[i])
                    {
                        x = randgen.Next(1, 52);
                        CardsInPlay[amount] = deck[x, 1].ToString() + deck[x, 0].ToString();
                        if (Player)
                        {
                            playerList[amount] = Convert.ToInt16(deck[x, 0]);
                        }
                        else
                        {
                            dealerList[amount] = Convert.ToInt16(deck[x, 0]);
                        }
                    }
                }

                cardDisplay = cardSet[x];
                Refresh();
            }
        }

        public int amountCount()
        {
            int result;
            if (Player == true)
            {
                playerAmount = 0;
                for (int i = 0; i <= amount; i++)
                {
                    if (playerList[i] > 10)
                    {
                        playerAmount = playerAmount + 10;
                    }
                    else if (playerList[i] == 1)
                    {
                        if (playerAmount + 11 > 21)
                        {
                            playerAmount = playerAmount + 1;
                        }
                        else
                        {
                            playerAmount = playerAmount + 11;
                        }
                    }
                    else
                    {
                        playerAmount = playerAmount + playerList[i];
                    }
                }
                result = playerAmount;
            }
            else
            {
                dealer = 0;
                for (int i = 0; i <= amount; i++)
                {
                    if (dealerList[i] > 10)
                    {
                        dealer = dealer + 10;


                    }
                    else if (dealerList[i] == 1)
                    {
                        if (dealer + 11 > 21)
                        {
                            dealer = dealer + 1;
                        }
                        else
                        {
                            dealer = dealer + 11;
                        }
                    }
                    else
                    {
                        dealer = dealer + dealerList[i];
                    }
                }
                result = dealer;
            }
            return result;
        }

        public void end()
        {

            Player = true;
            int endPlayer = amountCount();
            Player = false;
            int endDealer = amountCount();
            if (endPlayer > 21)
            {
                Thread.Sleep(400);
                resultLable.Text = "You Lost";
                Thread.Sleep(400);
                // Loss
                pot = 0;
                playerAmount = 0;
                dealer = 0;
                stand = false;
                start = true;
                button4.Visible = true;
                button3.Visible = false;

                d1.Image = null;
                d2.Image = null;
                d3.Image = null;
                d4.Image = null;
                d5.Image = null;
                p1.Image = null;
                p2.Image = null;
                p3.Image = null;
                p4.Image = null;
                p5.Image = null;
                p6.Image = null;
                p7.Image = null;

                d1.Visible = false;
                d2.Visible = false;
                d3.Visible = false;
                d4.Visible = false;
                d5.Visible = false;
                p1.Visible = false;
                p2.Visible = false;
                p3.Visible = false;
                p4.Visible = false;
                p5.Visible = false;
                p7.Visible = false;
                p6.Visible = false;

                for (int i = 0; i <= amount; i++)
                {
                    CardsInPlay[i] = null;
                    playerList[i] = 0;
                    dealerList[i] = 0;
                }

                amount = -1;
                display();
                dealerCardCount = 0;
            } /// Loos
            else if (endDealer > 21)
            {
                Thread.Sleep(400);
                resultLable.Text = "You Win";
                Thread.Sleep(400);
                // Win
                Start.playerCash = Start.playerCash + (pot * 2);
                pot = 0;
                playerAmount = 0;
                dealer = 0;
                stand = false;
                start = true;
                button4.Visible = true;
                button3.Visible = false;

                d1.Image = null;
                d2.Image = null;
                d3.Image = null;
                d4.Image = null;
                d5.Image = null;
                p1.Image = null;
                p2.Image = null;
                p3.Image = null;
                p4.Image = null;
                p5.Image = null;
                p6.Image = null;
                p7.Image = null;

                d1.Visible = false;
                d2.Visible = false;
                d3.Visible = false;
                d4.Visible = false;
                d5.Visible = false;
                p1.Visible = false;
                p2.Visible = false;
                p3.Visible = false;
                p4.Visible = false;
                p5.Visible = false;
                p7.Visible = false;
                p6.Visible = false;

                for (int i = 0; i <= amount; i++)
                {
                    CardsInPlay[i] = "";
                    playerList[i] = 0;
                    dealerList[i] = 0;
                }

                display();
                amount = -1;
                dealerCardCount = 0;
            } /// Win
            else if (endDealer == 21)
            {
                Thread.Sleep(400);
                resultLable.Text = "You Lost";
                Thread.Sleep(400);
                // Loss
                pot = 0;
                playerAmount = 0;
                dealer = 0;
                stand = false;
                start = true;
                button4.Visible = true;
                button3.Visible = false;

                d1.Image = null;
                d2.Image = null;
                d3.Image = null;
                d4.Image = null;
                d5.Image = null;
                p1.Image = null;
                p2.Image = null;
                p3.Image = null;
                p4.Image = null;
                p5.Image = null;
                p6.Image = null;
                p7.Image = null;

                d1.Visible = false;
                d2.Visible = false;
                d3.Visible = false;
                d4.Visible = false;
                d5.Visible = false;
                p1.Visible = false;
                p2.Visible = false;
                p3.Visible = false;
                p4.Visible = false;
                p5.Visible = false;
                p7.Visible = false;
                p6.Visible = false;

                for (int i = 0; i <= amount; i++)
                {
                    CardsInPlay[i] = null;
                    playerList[i] = 0;
                    dealerList[i] = 0;
                }

                amount = -1;
                display();
                dealerCardCount = 0;
            } /// Loss
            else if (endPlayer == 21)
            {
                Thread.Sleep(400);
                resultLable.Text = "You Win";
                Thread.Sleep(400);
                // Win
                Start.playerCash = Start.playerCash + (pot * 2);
                pot = 0;
                playerAmount = 0;
                dealer = 0;
                stand = false;
                start = true;
                button4.Visible = true;
                button3.Visible = false;

                d1.Image = null;
                d2.Image = null;
                d3.Image = null;
                d4.Image = null;
                d5.Image = null;
                p1.Image = null;
                p2.Image = null;
                p3.Image = null;
                p4.Image = null;
                p5.Image = null;
                p6.Image = null;
                p7.Image = null;

                d1.Visible = false;
                d2.Visible = false;
                d3.Visible = false;
                d4.Visible = false;
                d5.Visible = false;
                p1.Visible = false;
                p2.Visible = false;
                p3.Visible = false;
                p4.Visible = false;
                p5.Visible = false;
                p7.Visible = false;
                p6.Visible = false;

                for (int i = 0; i <= amount; i++)
                {
                    CardsInPlay[i] = "";
                    playerList[i] = 0;
                    dealerList[i] = 0;
                }
                display();
                amount = -1;
                dealerCardCount = 0;
            } /// Win
            else if (stand && (endDealer == endPlayer))
            {
                resultLable.Text = "You Tie";
                Start.playerCash = Start.playerCash + pot;

                pot = 0;
                playerAmount = 0;
                dealer = 0;
                stand = false;
                start = true;
                button4.Visible = true;
                button3.Visible = false;

                d1.Visible = false;
                d2.Visible = false;
                d3.Visible = false;
                d4.Visible = false;
                d5.Visible = false;
                p1.Visible = false;
                p2.Visible = false;
                p3.Visible = false;
                p4.Visible = false;
                p5.Visible = false;
                p7.Visible = false;
                p6.Visible = false;

                d1.Image = null;
                d2.Image = null;
                d3.Image = null;
                d4.Image = null;
                d5.Image = null;
                p1.Image = null;
                p2.Image = null;
                p3.Image = null;
                p4.Image = null;
                p5.Image = null;
                p6.Image = null;
                p7.Image = null;

                for (int i = 0; i <= amount; i++)
                {
                    CardsInPlay[i] = null;
                    playerList[i] = 0;
                    dealerList[i] = 0;
                }

                amount = -1;
                display();
                dealerCardCount = 0;
            } /// Draw
            else if (stand && ((endPlayer > endDealer) ||  (endDealer > endPlayer)))
            {
                if (endDealer > endPlayer)
                {
                    resultLable.Text = "You Lost";
                    pot = 0;
                }

                if (endPlayer > endDealer)
                {
                    resultLable.Text = "You Win";
                    Start.playerCash = Start.playerCash + (pot * 2);
                    pot = 0;
                }
                playerAmount = 0;
                dealer = 0;
                stand = false;
                start = true;
                button4.Visible = true;
                button3.Visible = false;

                d1.Visible = false;
                d2.Visible = false;
                d3.Visible = false;
                d4.Visible = false;
                d5.Visible = false;
                p1.Visible = false;
                p2.Visible = false;
                p3.Visible = false;
                p4.Visible = false;
                p5.Visible = false;
                p7.Visible = false;
                p6.Visible = false;

                d1.Image = null;
                d2.Image = null;
                d3.Image = null;
                d4.Image = null;
                d5.Image = null;
                p1.Image = null;
                p2.Image = null;
                p3.Image = null;
                p4.Image = null;
                p5.Image = null;
                p6.Image = null;
                p7.Image = null;

                for (int i = 0; i <= amount; i++)
                {
                    CardsInPlay[i] = null;
                    playerList[i] = 0;
                    dealerList[i] = 0;
                }

                amount = -1;
                display();
                dealerCardCount = 0;
            }

        }

        public void Hit_Click(object sender, EventArgs e)
        {

            if (start == true)
            {
                resultLable.Text = "";

                Player = true;
                drawCard();
                p1.Visible = true;
                p1.Image = cardDisplay;
                Player = false;
                drawCard();
                d1.Visible = true;
                d1.Image = cardDisplay;
                Player = true;
                drawCard();
                p2.Visible = true;
                p2.Image = cardDisplay;
                Player = false;
                drawCard();
                d2.Visible = true;
                hidenCard = cardDisplay;
                d2.Image = Properties.Resources.cardBack;

                start = false;
            }
            else
            {
                button4.Visible = false;
                button3.Visible = false;
                Player = true;
                drawCard();
                // display the card as player card
                switch (amount)
                {
                    case 4:
                        p3.Visible = true;
                        p3.Image = cardDisplay;
                        break;
                    case 5:
                        p4.Visible = true;
                        p4.Image = cardDisplay;
                        break;
                    case 6:
                        p5.Visible = true;
                        p5.Image = cardDisplay;
                        break;
                    case 7:
                        p6.Visible = true;
                        p6.Image = cardDisplay;
                        break;
                    case 8:
                        p7.Visible = true;
                        p7.Image = cardDisplay;
                        break;

                }

            }

            Player = true;
            currentCardCount = amountCount();
            playerLable.Text = currentCardCount.ToString();
            display();
            end();

        }

        private void button3_Click(object sender, EventArgs e) // Split
        {
            SplitCard = p2.Image;
            p2.Image = null;
        }

        private void button4_Click(object sender, EventArgs e) // Double
        {
            if (start == false)
            {
                pot = pot * 2;
                drawCard();
                p3.Visible = true;
                p3.Image = cardDisplay;
                display();
                Refresh();
                Thread.Sleep(500);
                button5_Click(sender, e);
            }

        }

        private void button5_Click(object sender, EventArgs e) // Stand
        {
            Player = false;
            int testValue = amountCount();
            if (start == false)
            {
                d2.Image = hidenCard;
                stand = true;
                while (stand == true)
                {
                    testValue = amountCount();
                    Thread.Sleep(500);
                    display();
                    Refresh();
                    if (testValue < 16)
                    {
                        dealerCardCount++;
                        d3.Image = cardDisplay;
                        drawCard();
                        Refresh();
                        // display the card
                        switch (dealerCardCount)
                        {
                            case 1:
                                d3.Visible = true;
                                d3.Image = cardDisplay;
                                display();
                                break;
                            case 2:
                                d4.Visible = true;
                                d4.Image = cardDisplay;
                                display();
                                break;
                            case 3:
                                d5.Visible = true;
                                d5.Image = cardDisplay;
                                display();
                                break;
                        }
                        Thread.Sleep(500);
                        display();
                        Refresh();
                    }
                    else
                    {
                        Thread.Sleep(500);
                        end();
                        display();
                        stand = false;
                    }
                }
            }
        }
    }
}
