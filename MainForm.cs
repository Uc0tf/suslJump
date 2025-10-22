using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Susl_Jump
{
    public partial class MainForm : Form
    {
        string username = "guest";

        Items.Susl susl;
        List<Panel> platformList = new List<Panel>();
        System.Windows.Forms.Timer ScoreTimer = new System.Windows.Forms.Timer();
        Items.ScoreLabel ScoreLabel = new Items.ScoreLabel();
        Items.CoinsLabel CoinsLabel = new Items.CoinsLabel();
        Items.ShieldLabel ShieldLabel= new Items.ShieldLabel();
        Items.userNameLabel userNameLabel = new Items.userNameLabel();

        bool waitingKeyPress = false;
        Keys[] controlKeysArr = new Keys[4];
        Label currentlabel;
        bool gameStarted = false;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        string menu;
        int centerForMenuWidth;
        int centerForMenuHeidth;
        bool menuKeyPressed = false;

        public MainForm()
        {
            InitializeComponent();

            showSusl();

            CreateInfoLabels();
            CorrectMenusPositions();
            CorrectButtonPosition();
            useDefaultKeys();

            timer.Interval = 1;
            timer.Tick += Timer_Tick;

            ScoreTimer.Interval = 1;
            ScoreTimer.Tick += ScoreTimer_Tick;

            buttonExit.BringToFront();
            Focus();
            susl.BringToFront();

            susl.setData(username);
        }

        public void login(string username)
        {
            this.username = username;

            if (this.username == "admin69")
            {
                susl.Coins = 999;
                susl.Shields = 999;
                susl.SetScore(6942069);
                ScoreLabel.Text = susl.ReadScore().ToString();
                CoinsLabel.Text = susl.Coins.ToString() + " 💰";
                ShieldLabel.Text = susl.Shields.ToString();
                saveData();
            }

            userNameLabel.Text = this.username;
            loadData();
        }

        private void loadData()
        {
            string[] users = Properties.Settings.Default.Users.ToString().Split('^');
            string[] usernames = new string[users.Length];

            for (int i = 0; i < users.Length; i++)
            {
                try
                {
                    usernames[i] = users[i].Split(';')[0];
                }
                catch (Exception)
                {
                    usernames[i] = users[i];
                }
            }

            if (usernames.Contains(username))
            {
                for (int i = 0; i < users.Length; i++)
                {
                    if (usernames[i] == username)
                    {
                        susl.Coins = int.Parse(users[i].Split(';')[2]);
                        susl.Shields = int.Parse(users[i].Split(';')[3]);
                        i = users.Length;
                    }
                }
            }
            else
            {
                susl.Coins = 0;
                susl.Shields = 0;
            }

            CoinsLabel.Text = susl.Coins.ToString() + " 💰";
            ShieldLabel.Text = susl.Shields.ToString();
        }

        private void saveData()
        {
            string[] users = Properties.Settings.Default.Users.ToString().Split('^');
            string[] usernames = new string[users.Length];

            for (int i = 0; i < users.Length; i++)
            {
                try
                {
                    usernames[i] = users[i].Split(';')[0];
                }
                catch (Exception)
                {
                    usernames[i] = users[i];
                }
            }

            if (usernames.Contains(username))
            {
                for (int i = 0; i < users.Length; i++)
                {
                    if (usernames[i] == username)
                    {
                        users[i] = $"{username};{hightScore()};{CoinsLabel.Text.Split(' ')[0]};{ShieldLabel.Text}";
                    }
                }

                string newUsers = "";

                foreach (string user in users)
                {
                    if (user.Length > 5)
                    {
                        newUsers += user + "^";
                    }
                }

                Properties.Settings.Default.Users = newUsers;
            }
            else
            {
                Properties.Settings.Default.Users += $"{username};{ScoreLabel.Text};{CoinsLabel.Text.Split(' ')[0]};{ShieldLabel.Text}^";
            }

            Properties.Settings.Default.Save();
        }

        private string hightScore()
        {
            string[] users = Properties.Settings.Default.Users.ToString().Split('^');
            string[] usernames = new string[users.Length];

            for (int i = 0; i < users.Length; i++)
            {
                try
                {
                    usernames[i] = users[i].Split(';')[0];
                }
                catch (Exception)
                {
                    usernames[i] = users[i];
                }
            }

            if (usernames.Contains(username))
            {
                for (int i = 0; i < users.Length; i++)
                {
                    if (usernames[i] == username)
                    {
                        if (int.Parse(users[i].Split(';')[1]) > int.Parse(ScoreLabel.Text))
                        {
                            return users[i].Split(';')[1];
                        }
                        else
                        {
                            return ScoreLabel.Text;
                        }
                    }
                }
            }
            return ScoreLabel.Text;
        }

        private void showSusl()
        {
            if (susl == null)
            {
                susl = new Items.Susl(this);
                Controls.Add(susl);
            }

            susl.gameLose = false;
            susl.Location = new Point(30, Height / 2 + 75);
            susl.BringToFront();

            for (int j = 0; j < 9; j++)
            {
                Panel platform = new Items.Platform(Size);

                platformList.Add(platform);
                Controls.Add(platformList[platformList.Count - 1]);
                platform.BringToFront();

                if (j != 8)
                {
                    susl.movePlatforms(platformList, 80);
                }
            }
            platformList[0].Location = new Point(28, platformList[0].Location.Y);
            susl.SendPlatform(platformList[0]);
            susl.StartJumping();
        }

        private void CreateInfoLabels()
        {
            Controls.Add(ScoreLabel);
            ScoreLabel.BringToFront();

            Controls.Add(CoinsLabel);
            CoinsLabel.BringToFront();

            Controls.Add(ShieldLabel);
            ShieldLabel.BringToFront();

            Controls.Add(userNameLabel);
            userNameLabel.BringToFront();

            userNameLabel.Text = username;
        }

        private void ScoreTimer_Tick(object? sender, EventArgs e)
        {
            ScoreLabel.Text = susl.ReadScore().ToString();
            CoinsLabel.Text = susl.Coins.ToString() + " 💰";
            ShieldLabel.Text = susl.Shields.ToString();

            if (susl.Location.Y > Height)
            {
                loseGame();
            }
        }

        private void loseGame()
        {
            susl.dellEnemy();
            susl.dellShield();
            susl.StopMove();
            
            saveData();
            panelMainMenu.Enabled = true;
            panelSettings.Enabled = true;
            panelLeaderboard.Enabled = true;
            panelShop.Enabled = true;
            gameStarted = false;
            ScoreTimer.Stop();
            
            foreach (var item in platformList)
            {
                Controls.Remove(item);
                item.Dispose();
            }
            platformList.Clear();
            susl.clearPlatforms();

            showSusl();

            CorrectMenusPositions();
            susl.BringToFront();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            switch (menu)
            {
                case "play":
                    if (panelMainMenu.Location.Y + panelMainMenu.Height > 0)
                    {
                        panelMainMenu.Location = new Point(panelMainMenu.Location.X, panelMainMenu.Location.Y - 5);
                    }
                    else
                    {
                        timer.Stop();
                        menuKeyPressed = false;

                        startGame();
                    }
                    break;
                case "settings":
                    if (panelMainMenu.Location.Y + panelMainMenu.Height > 0)
                    {
                        panelMainMenu.Location = new Point(panelMainMenu.Location.X, panelMainMenu.Location.Y - 5);
                    }
                    else
                    {
                        timer.Stop();
                        Focus();
                        menuKeyPressed = false;
                    }
                    if (panelSettings.Location.X < centerForMenuWidth)
                    {
                        panelSettings.Location = new Point(panelSettings.Location.X + 5, panelSettings.Location.Y);
                    }
                    break;
                case "leaders":
                    if (panelMainMenu.Location.Y + panelMainMenu.Height > 0)
                    {
                        panelMainMenu.Location = new Point(panelMainMenu.Location.X, panelMainMenu.Location.Y - 5);
                    }
                    else
                    {
                        timer.Stop();
                        Focus();
                        menuKeyPressed = false;
                    }
                    if (panelLeaderboard.Location.X > centerForMenuWidth)
                    {
                        panelLeaderboard.Location = new Point(panelLeaderboard.Location.X - 5, panelSettings.Location.Y);
                    }
                    break;
                case "shop":
                    if (panelMainMenu.Location.Y + panelMainMenu.Height > 0)
                    {
                        panelMainMenu.Location = new Point(panelMainMenu.Location.X, panelMainMenu.Location.Y - 5);
                    }
                    else
                    {
                        timer.Stop();
                        Focus();
                        menuKeyPressed = false;
                    }
                    if (panelShop.Location.Y > centerForMenuHeidth)
                    {
                        panelShop.Location = new Point(panelShop.Location.X, panelShop.Location.Y - 5);
                    }
                    break;
                case "main":
                    if (panelMainMenu.Location.Y < centerForMenuHeidth)
                    {
                        panelMainMenu.Location = new Point(panelMainMenu.Location.X, panelMainMenu.Location.Y + 5);
                    }
                    else
                    {
                        timer.Stop();
                        Focus();
                        menuKeyPressed = false;
                    }
                    if (panelLeaderboard.Location.X < Width)
                    {
                        panelLeaderboard.Location = new Point(panelLeaderboard.Location.X + 5, panelSettings.Location.Y);
                    }
                    if (panelSettings.Location.X + panelSettings.Width > 0)
                    {
                        panelSettings.Location = new Point(panelSettings.Location.X - 5, panelSettings.Location.Y);
                    }
                    if (panelShop.Location.Y < Height)
                    {
                        panelShop.Location = new Point(panelShop.Location.X, panelShop.Location.Y + 5);
                    }
                    break;
                default:
                    break;
            }
        }

        private void useDefaultKeys()
        {
            Keys[] controlKeysArr = { Keys.Left, Keys.Right, Keys.Space, Keys.X };
            this.controlKeysArr = controlKeysArr;
        }

        private void CorrectButtonPosition()
        {
            int centerForButtonWidth = (panelMainMenu.Width / 2) - (buttonShop.Width / 2);
            int centerForButtonHeidth = (panelMainMenu.Height / 2) - (buttonShop.Height / 2);
            
            buttonPlay.Location = new Point(centerForButtonWidth, centerForButtonHeidth - buttonPlay.Height - 10);
            buttonShop.Location = new Point(centerForButtonWidth, centerForButtonHeidth);
            buttonLeaders.Location = new Point(centerForButtonWidth, centerForButtonHeidth + buttonLeaders.Height + 10);
        }
        
        private void CorrectMenusPositions()
        {
            pictureBoxBackground.Location = new Point(0,0);

            centerForMenuWidth = (Width/2) - (panelMainMenu.Width / 2);
            centerForMenuHeidth = (Height / 2) - (panelMainMenu.Height / 2);

            panelMainMenu.BringToFront();
            panelMainMenu.Location = new Point(centerForMenuWidth, centerForMenuHeidth);
            panelSettings.Location = new Point(-panelSettings.Width, centerForMenuHeidth);
            panelLeaderboard.Location = new Point(Width, centerForMenuHeidth);
            panelShop.Location = new Point(centerForMenuWidth, Height);

            panelShop.BringToFront();
            panelLeaderboard.BringToFront();
            panelSettings.BringToFront();
            panelMainMenu.BringToFront();
        }

        private void labelsKey_Click(object sender, EventArgs e)
        {
            if (!waitingKeyPress)
            {
                buttonBack.Enabled = false;
                buttonExit.Enabled = false;
                currentlabel = (Label)sender;
                string name = currentlabel.Name;
                currentlabel.Focus();

                switch (name)
                {
                    case "labelLeftKey":
                        controlKeysArr[0] = Keys.Escape;
                        break;
                    case "labelRightKey":
                        controlKeysArr[1] = Keys.Escape;
                        break;
                    case "labelShootKey":
                        controlKeysArr[2] = Keys.Escape;
                        break;
                    case "labelShieldKey":
                        controlKeysArr[3] = Keys.Escape;
                        break;
                    default:
                        break;
                }

                currentlabel.Text = "???";
                currentlabel.ForeColor = Color.Black;
                currentlabel.BackColor = Color.DarkGray;
                waitingKeyPress = true;
                Focus();
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (gameStarted && !waitingKeyPress)
            {
                if (e.KeyCode == controlKeysArr[0])
                {
                    susl.OnLeft();
                }
                else if (e.KeyCode == controlKeysArr[1])
                {
                    susl.OnRight();
                }
                else if (e.KeyCode == controlKeysArr[2])
                {
                    susl.useSpell();
                }

                else if (e.KeyCode == controlKeysArr[3])
                {
                    susl.useShield();
                }
            }
        }
        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == controlKeysArr[0] || e.KeyCode == controlKeysArr[1] && gameStarted)
            {
                susl.StopMove();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (!menuKeyPressed)
            {
                menuKeyPressed = true;
                menu = "play";
                timer.Start();
            }
        }

        private void startGame()
        {
            loadData();
            panelMainMenu.Enabled = false;
            panelSettings.Enabled = false;
            panelLeaderboard.Enabled = false;
            panelShop.Enabled = false;
            gameStarted = true;

            susl.SetScore(0);
            susl.SendPlatforms(platformList);
            Focus();
            ScoreTimer.Start();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            if (!menuKeyPressed)
            {
                menuKeyPressed = true;
                menu = "settings";
                timer.Start();
            }
        }

        private void buttonLeaders_Click(object sender, EventArgs e)
        {
            if (!menuKeyPressed)
            {
                menuKeyPressed = true;
                menu = "leaders";
                timer.Start();
            }
            showScore();
        }

        private void showScore()
        {
            textBoxLeaders.ResetText();

            string[] users = Properties.Settings.Default.Users.ToString().Split('^');
            int scoreLenght = 0;
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i] != "")
                {
                    scoreLenght++;
                }
            }
            int[] scores = new int[scoreLenght];

            int scoreCount = 0;
            foreach (string user in users)
            {
                if (user != "")
                {
                    scores[scoreCount] = int.Parse(user.Split(';')[1]);
                    scoreCount++;
                }
            }
            scoreCount = 0;

            Array.Sort(scores);
            Array.Reverse(scores);

            string[,] leaders = new string[2, scores.Length];

            for (int i = 0; i < leaders.GetLength(1); i++)
            {
                leaders[1, i] = scores[i].ToString();
                for (int j = 0; j < users.Length; j++)
                {
                    if (users[j].Length > 5 && int.Parse(users[j].Split(';')[1]) == scores[i] && !leaderIn(leaders, users[j]))
                    {
                        leaders[0, i] = users[j].Split(';')[0];
                        j = users.Length;
                    }
                }
            }

            for (int i = 0; i < leaders.GetLength(1); i++)
            {
                string leader = leaders[0, i] + "\t << = >> \t" + leaders[1, i];
                textBoxLeaders.AppendText(leader);
                textBoxLeaders.AppendText(Environment.NewLine);
            }

        }

        private bool leaderIn(string[,] leadres, string cUser)
        {
            List<string> leaders = new List<string>();

            for (int i = 0; i < leadres.GetLength(1); i++)
            {
                if (leadres[0,i] != null)
                {
                    leaders.Add(leadres[0,i]);
                }
            }

            if (leaders.Contains(cUser.Split(';')[0]))
            {
                return true;
            }

            return false;
        }

        private void buttonShop_Click(object sender, EventArgs e)
        {
            labelShopInfo.ForeColor = Color.White;
            labelShopInfo.Text = "";

            if (!menuKeyPressed)
            {
                menuKeyPressed = true;
                menu = "shop";
                timer.Start();
            }
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (!menuKeyPressed)
            {
                menuKeyPressed = true;
                menu = "main";
                timer.Start();
            }
        }

        private void labelsKey_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (waitingKeyPress)
            {
                if (!controlKeysArr.Contains(e.KeyCode) && e.KeyCode != Keys.Escape)
                {
                    currentlabel.Text = e.KeyCode.ToString();
                    currentlabel.ForeColor = Color.White;
                    currentlabel.BackColor = Color.Black;
                    waitingKeyPress = false;

                    string name = currentlabel.Name;
                    switch (name)
                    {
                        case "labelLeftKey":
                            controlKeysArr[0] = e.KeyCode;
                            break;
                        case "labelRightKey":
                            controlKeysArr[1] = e.KeyCode;
                            break;
                        case "labelShootKey":
                            controlKeysArr[2] = e.KeyCode;
                            break;
                        case "labelShieldKey":
                            controlKeysArr[3] = e.KeyCode;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    currentlabel.Text = "???";
                    currentlabel.ForeColor = Color.White;
                    currentlabel.BackColor = Color.Black;
                    waitingKeyPress = false;
                }
                buttonBack.Enabled = true;
                buttonExit.Enabled = true;
            }
        }

        #region moveWindow
        bool mouseOnPanel = false;
        Point mouseDownPoin;
        private void panelMove_MouseDown(object sender, MouseEventArgs e)
        {
            mouseOnPanel = true;
            mouseDownPoin = new Point(e.X, e.Y);
        }
        private void panelMove_MouseUp(object sender, MouseEventArgs e)
        {
            mouseOnPanel = false;
        }

        private void panelMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseOnPanel)
            {
                int x = e.Location.X + Location.X - mouseDownPoin.X;
                int y = e.Location.Y + Location.Y - mouseDownPoin.Y;
                Location = new Point(x, y);
            }
        }
        #endregion moveWindow

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveData();

        }

        private void buttonShieldBuy_Click(object sender, EventArgs e)
        {
            if (susl.Coins < 2)
            {
                labelShopInfo.ForeColor = Color.Red;
                labelShopInfo.Text = "You don't have money to buy this item...";
            }
            else
            {
                labelShopInfo.ForeColor = Color.White;
                susl.Coins -= 2;
                susl.Shields += 1;

                labelShopInfo.Text = "okaaay. You bought one Shield, go play with new defence item";

                ShieldLabel.Text = susl.Shields.ToString();
                CoinsLabel.Text = susl.Coins.ToString() + " 💰";

                saveData();
            }
        }
    }
}
