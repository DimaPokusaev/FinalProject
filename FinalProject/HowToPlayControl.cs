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
    public partial class HowToPlayControl : UserControl
    {
        public HowToPlayControl()
        {
            InitializeComponent();
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
