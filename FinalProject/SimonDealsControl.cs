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
    public partial class SimonDealsControl : UserControl
    {
        public SimonDealsControl()
        {
            InitializeComponent();

            
        }

        Random randgen = new Random();

        Image[] cardSet = new Image[52] { Properties.Resources.S14, Properties.Resources.S2, Properties.Resources.S3, Properties.Resources.S4, Properties.Resources.S5, Properties.Resources.S6, Properties.Resources.S7, Properties.Resources.S8, Properties.Resources.S9, Properties.Resources.S10, Properties.Resources.S11, Properties.Resources.S12, Properties.Resources.S13, Properties.Resources.H14, Properties.Resources.H2, Properties.Resources.H3, Properties.Resources.H4, Properties.Resources.H5, Properties.Resources.H6, Properties.Resources.H7, Properties.Resources.H8, Properties.Resources.H9, Properties.Resources.H10, Properties.Resources.H11, Properties.Resources.H12, Properties.Resources.H13, Properties.Resources.D14, Properties.Resources.D2, Properties.Resources.D3, Properties.Resources.D4, Properties.Resources.D5, Properties.Resources.D6, Properties.Resources.D7, Properties.Resources.D8, Properties.Resources.D9, Properties.Resources.D10, Properties.Resources.D11, Properties.Resources.D12, Properties.Resources.D13, Properties.Resources.C14, Properties.Resources.C2, Properties.Resources.C3, Properties.Resources.C4, Properties.Resources.C5, Properties.Resources.C6, Properties.Resources.C7, Properties.Resources.C8, Properties.Resources.C9, Properties.Resources.C10, Properties.Resources.C11, Properties.Resources.C12, Properties.Resources.C13 };
        string[,] deck = new string[52, 2] { { "1", "S" }, { "2", "S" }, { "3", "S" }, { "4", "S" }, { "5", "S" }, { "6", "S" }, { "7", "S" }, { "8", "S" }, { "9", "S" }, { "10", "S" }, { "11", "S" }, { "12", "S" }, { "13", "S" }, { "1", "H" }, { "2", "H" }, { "3", "H" }, { "4", "H" }, { "5", "H" }, { "6", "H" }, { "7", "H" }, { "8", "H" }, { "9", "H" }, { "10", "H" }, { "11", "H" }, { "12", "H" }, { "13", "H" }, { "1", "D" }, { "2", "D" }, { "3", "D" }, { "4", "D" }, { "5", "D" }, { "6", "D" }, { "7", "D" }, { "8", "D" }, { "9", "D" }, { "10", "D" }, { "11", "D" }, { "12", "D" }, { "13", "D" }, { "1", "C" }, { "2", "C" }, { "3", "C" }, { "4", "C" }, { "5", "C" }, { "6", "C" }, { "7", "C" }, { "8", "C" }, { "9", "C" }, { "10", "C" }, { "11", "C" }, { "12", "C" }, { "13", "C" } };
        Image[] currentSet = new Image[4];
        List<int> pattern = new List<int>();

        int counter, current;
        Boolean start = false, done = true;

        private void MM_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            MainMenuContrrol ms = new MainMenuContrrol();
            f.Controls.Add(ms);
        }

        private void startLable_Click(object sender, EventArgs e)
        {
            if (start == false)
            {
                done = false;
                start = true;
                startLable.Text = "Stop";

                for (int i = 0; i < 4; i++)
                {
                    currentSet[i] = cardSet[randgen.Next(1, 51)];
                }

                button1.Image = currentSet[0];
                button2.Image = currentSet[1];
                button3.Image = currentSet[2];
                button4.Image = currentSet[3];
                counter = 0;
                simon();

                done = false;
            }
            else
            {
                pattern.Clear();
                start = false;
                startLable.Text = "Start";
            }


        }

        void simon()
        {
            scoreLable.Text = "Score: " + counter;
            current = 0;
            pattern.Add(randgen.Next(1, 4));
            counter++;
            for (int i = 0; i < counter; i++)
            {
                switch (pattern[i])
                {
                    case 1:
                        button1.FlatAppearance.BorderColor = Color.Green;
                        break;
                    case 2:
                        button2.FlatAppearance.BorderColor = Color.Green;
                        break;
                    case 3:
                        button3.FlatAppearance.BorderColor = Color.Green;
                        break;
                    case 4:
                        button4.FlatAppearance.BorderColor = Color.Green;
                        break;
                }
                Refresh();
                Thread.Sleep(1000);

                button1.FlatAppearance.BorderColor = Color.Red;
                button2.FlatAppearance.BorderColor = Color.Red;
                button3.FlatAppearance.BorderColor = Color.Red;
                button4.FlatAppearance.BorderColor = Color.Red;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (done == false)
            {
                if (1 == pattern[current])
                {
                    current++;
                    button1.Image = null;
                    button1.BackColor = Color.Green;
                    Refresh();
                    Thread.Sleep(100);
                    button1.Image = currentSet[0];

                    if (current == counter)
                    {
                        simon();
                    }
                }
                else
                {
                    button1.Image = null;
                    button1.BackColor = Color.Red;
                    Refresh();
                    done = true;
                    start = false;
                    startLable.Text = "Start";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (done == false)
            {
                if (2 == pattern[current])
                {
                    current++;
                    button2.Image = null;
                    button2.BackColor = Color.Green;
                    Refresh();
                    Thread.Sleep(200);
                    button2.Image = currentSet[1];

                    if (current == counter)
                    {
                        simon();
                    }
                }
                else
                {
                    button2.Image = null;
                    button2.BackColor = Color.Red;
                    Refresh();
                    done = true;
                    start = false;
                    startLable.Text = "Start";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (done == false)
            {
                if (3 == pattern[current])
                {
                    current++;
                    button3.Image = null;
                    button3.BackColor = Color.Green;
                    Refresh();
                    Thread.Sleep(100);
                    button3.Image = currentSet[2];

                    if (current == counter)
                    {
                        simon();
                    }
                }
                else
                {
                    button3.Image = null;
                    button3.BackColor = Color.Red;
                    Refresh();
                    done = true;
                    start = false;
                    startLable.Text = "Start";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (done == false)
            {
                if (4 == pattern[current])
                {
                    current++;
                    button4.Image = null;
                    button4.BackColor = Color.Green;
                    Refresh();
                    Thread.Sleep(200);
                    button4.Image = currentSet[3];

                    if (current == counter)
                    {
                        simon();
                    }
                }
                else
                {
                    button4.Image = null;
                    button4.BackColor = Color.Red;
                    Refresh();
                    done = true;
                    start = false;
                    startLable.Text = "Start";
                }
            }
        }
    }
}