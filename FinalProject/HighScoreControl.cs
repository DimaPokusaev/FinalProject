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
    public partial class HighScoreControl : UserControl
    {


        public HighScoreControl()
        {
            InitializeComponent();
            if(!(Start.score.Count == 0))
            {
                richTextBox1.Text = "";
            }

            for (int i = 0; i < Start.score.Count; i++)
            {
                richTextBox1.Text += (i + 1) + ".   " + Start.score[i] + "\n";
            }
        }

        private void MM_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            MainMenuContrrol ms = new MainMenuContrrol();
            f.Controls.Add(ms);
        }
    }
}
