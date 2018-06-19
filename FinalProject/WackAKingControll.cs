using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class WackAKingControll : UserControl
    {
        public WackAKingControll()
        {
            InitializeComponent();
        }

        Random randGen = new Random();
        int score;
        Boolean start = true;
        Image[] cardSet = new Image[4] { Properties.Resources.S13, Properties.Resources.H13, Properties.Resources.D13, Properties.Resources.C13 };

        private void MM_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            MainMenuContrrol ms = new MainMenuContrrol();
            f.Controls.Add(ms);
        }

        private void startLable_Click(object sender, EventArgs e)
        {
            if (start)
            {
                start = false;
                timer1.Enabled = true;
                startLable.Text = "Stop";
                button1.Image = cardSet[randGen.Next(0, 3)];
                timer1.Interval = 1000;
                score = 0;
                scoreLable.Text = "Score: " + score;
                Refresh();
            }
            else
            {
                button1.Image = null;
                button1.BackColor = Color.Red;
                timer1.Enabled = false;
                startLable.Text = "Start";
                start = true;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Location = new Point(randGen.Next(1, 729), randGen.Next(1, 336));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (start == false)
            {
                button1.Image = cardSet[randGen.Next(0, 3)];
                timer1.Interval = timer1.Interval - 10;
                score++;
                timer1_Tick(sender, e);
                scoreLable.Text = "Score: " + score;
                //Refresh();
            }
        }

        private void backDrop_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_2(object sender, EventArgs e)
        {
            button1.Location = new Point(randGen.Next(1, 729), randGen.Next(1, 336));

        }

        private void backDrop_Click_1(object sender, EventArgs e)
        {
            button1.Image = null;
            timer1.Enabled = false;
            start = true;
            button1.BackColor = Color.Red;
            startLable.Text = "Start";
            Refresh();
        }
    }
}
