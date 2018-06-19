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
    public partial class MiniGameListControl : UserControl
    {
        public MiniGameListControl()
        {
            InitializeComponent();
        }

        private void WackAKing_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            WackAKingControll ms = new WackAKingControll();
            f.Controls.Add(ms);
        }

        private void SimonDdeals_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            SimonDealsControl ms = new SimonDealsControl();
            f.Controls.Add(ms);
        }
    }
}
