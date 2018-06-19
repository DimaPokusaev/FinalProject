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
    public partial class MainMenuContrrol : UserControl
    {
        public MainMenuContrrol()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            MainGameControl ms = new MainGameControl();
            f.Controls.Add(ms);
        }

        private void Score_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            HighScoreControl ms = new HighScoreControl();
            f.Controls.Add(ms);
        }

        private void How_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            HowToPlayControl ms = new HowToPlayControl();
            f.Controls.Add(ms);
        }
    }
}
