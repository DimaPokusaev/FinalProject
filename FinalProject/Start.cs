using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Start : Form
    {
        static public string playerName = "";

        public Start()
        {
            InitializeComponent();

            StartControl sc = new StartControl();
            this.Controls.Add(sc);
        }

        public static int playerCash = 300;
        public static List<int> score = new List<int>();
    }
}
