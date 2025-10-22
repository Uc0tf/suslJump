using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Susl_Jump
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            if (textBoxUserName.Text == "")
            {
                labelInfo.Text = "Chose some username";
                buttonCheckName.Enabled = false;
            }
        }

        private void buttonCheckName_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainForm gameForm = new MainForm();
            gameForm.login(textBoxUserName.Text);

            gameForm.Closed += (s, args) => this.Close();

            gameForm.Show();
        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {
            string[] users = Properties.Settings.Default.Users.ToString().Split('^');

            for (int i = 0; i < users.Length; i++)
            {
                if (textBoxUserName.Text == "")
                {
                    labelInfo.Text = "Chose some username";
                    buttonCheckName.Enabled = false;
                }
                else if (textBoxUserName.Text == users[i].Split(';')[0] && textBoxUserName.Text != "admin69")
                {
                    labelInfo.Text = "Is this your username? If yes click 'Ok' and continue playing.";
                    buttonCheckName.Enabled = true;
                    i = users.Length;
                }
                else
                {
                    if (textBoxUserName.Text == "admin69")
                    {
                        labelInfo.Text = "you are so hot admin, godMode ON";
                        buttonCheckName.Enabled = true;
                    }
                    else
                    {
                        labelInfo.Text = $"Start new game as {textBoxUserName.Text} ?";
                        buttonCheckName.Enabled = true;
                    }
                }
            }

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
