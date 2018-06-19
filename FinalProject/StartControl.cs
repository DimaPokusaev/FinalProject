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
    public partial class StartControl : UserControl
    {
        public StartControl()
        {
            InitializeComponent();
        }
        int attempt = 0;

        private void startLable_Click(object sender, EventArgs e)
        {
            attempt++;

            switch (attempt)
            {
                case 1:
                    if (textBox1.Text == "Your Name")
                    {
                        scoreLable.Text = "Realy, Prease enter 'Your real name'";
                    }
                    else
                    {
                        scoreLable.Text = "Welcome " + textBox1.Text;
                        textBox1.Visible = false;
                        attempt = 99;
                    }
                    break;
                case 2:
                    if (textBox1.Text == "Your real name")
                    {
                        scoreLable.Text = "Ok, Sure, Lets go with that, Please confirm your mane";
                        textBox1.Text = "";
                    }
                    else
                    {
                        scoreLable.Text = "Welcome " + textBox1.Text;
                        textBox1.Visible = false;
                        attempt = 99;
                    }
                    break;
                case 3:
                    if (textBox1.Text == "Yes, it is my name")
                    {
                        scoreLable.Text = "*Sigh* Good enought, you may go, but for the record, what is your name";
                        textBox1.Text = "";
                    }
                    else
                    {
                        scoreLable.Text = "Welcome " + textBox1.Text;
                        textBox1.Visible = false;
                        attempt = 99;
                    }
                    break;
                case 4:
                    if (textBox1.Text == "I don't know your name, you never told me")
                    {
                        scoreLable.Text = "Karen";
                        textBox1.Text = "";
                    }
                    else
                    {
                        scoreLable.Text = "Welcome " + textBox1.Text;
                        textBox1.Visible = false;
                        attempt = 99;
                    }
                    break;
                case 100:
                    Form f = this.FindForm();
                    f.Controls.Remove(this);
                    MainMenuContrrol ms = new MainMenuContrrol();
                    f.Controls.Add(ms);

                    break;
                default:
                    scoreLable.Text = "Welcome " + textBox1.Text;
                    textBox1.Visible = false;
                    attempt = 99;
                    break;
            }
        }
    }
}
