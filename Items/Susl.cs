using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace Susl_Jump.Items
{
    internal class Susl : Panel
    {
        Enemy? enemy;
        Spell? spell;
        Shield? shield;
        Random random = new Random();
        Form gameForm;
        Panel? platform;
        List<Panel>? platforms;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        bool jump = false;
        int tick = 0;
        bool left;
        Size gameSize;
        int platformType;
        int jumpSpeed = 0;
        bool nowMoving;
        public bool gameLose = false;
        int Score { get; set; }
        public int Coins { get; set; }
        public int Shields { get; set; }

        bool usingShield = false;

        public Susl(Form gameForm)
        {
            BackColor = Color.MediumPurple;
            Size = new Size(60, 88);
            LeftSusl();

            Score = 0;
            this.gameForm = gameForm;
            this.gameSize = gameForm.Size;

            nowMoving = false;
            jump = true;
            tick = 0;
            gameLose = false;
            left = true;
            usingShield = false;

            timer.Interval = 1;
            timer.Tick += Timer_Tick;
        }

        public void dellEnemy()
        {
            if (enemy == null)
            {
                return;
            }
            gameForm.Controls.Remove(enemy);
            enemy.Dispose();
            enemy = null;
        }

        public void setData(string username)
        {
            if (Properties.Settings.Default.Users.ToString().Contains(username))
            {
                string[] users = Properties.Settings.Default.Users.ToString().Split('^');
                for (int i = 0; i < users.Length; i++)
                {
                    if (users[i].Contains(username))
                    {
                        Coins = int.Parse(users[i].Split(';')[2]);
                        Shields = int.Parse(users[i].Split(';')[3]);
                    }
                }
            }
            else
            {
                Coins = 0;
                Shields = 0;
            }
        }

        public void useSpell()
        {
            if (spell == null && !gameLose && !usingShield)
            {
                spell = new Spell(Location);
                gameForm.Controls.Add(spell);
            }
        }
        public void useShield()
        {
            if (shield == null && !gameLose && Shields > 0)
            {
                shield = new Shield(Location);
                gameForm.Controls.Add(shield);
                usingShield = true;
                Shields--;
                shield.BringToFront();
            }
        }
        private void LoseGame()
        {
            Location = new Point(Location.X, Location.Y + 10);
        }
        public void moveEnemy(int speed)
        {
            if (enemy != null)
            {
                enemy.BringToFront();
                enemy.Location = new Point(enemy.Location.X, enemy.Location.Y + speed);
                if (enemy.Location.Y > gameSize.Height)
                {
                    gameForm.Controls.Remove(enemy);
                    enemy.Dispose();
                    enemy = null;
                }
            }
        }
        public void movePlatforms(List<Panel> platformList, int speed)
        {
            foreach (var item in platformList)
            {
                item.Location = new Point(item.Location.X, item.Location.Y + speed);
            }
            for (int i = 0; i < platformList.Count; i++)
            {
                if (platformList[i].Location.Y > gameSize.Height)
                {
                    gameForm.Controls.Remove(platformList[i]);
                    platformList[i].Dispose();
                    platformList.RemoveAt(i);

                    CreatePlatform(platformList);
                }
            }
        }
        private void CreatePlatform(List<Panel> platformList)
        {
            Panel platform = new Platform(gameSize, platformList[platformList.Count - 1].Location.Y - 80);
            if (Score >= 500 && Score <= 530)
            {
                platform = new PlatformJump(gameSize, platformList[platformList.Count - 1].Location.Y - 80);
            }
            else if (Score >= 700 && Score <= 1000)
            {
                platform = new PlatformMove(gameSize, platformList[platformList.Count - 1].Location.Y - 80);
            }
            else if (Score >= 1200 && Score <= 1500)
            {
                platform = new PlatformDie(gameSize, platformList[platformList.Count - 1].Location.Y - 80);
            }
            else if (Score >= 1700)
            {
                int platformType = GenerateRandomPlatform();

                switch (platformType)
                {
                    case 1:
                        platform = new Platform(gameSize, platformList[platformList.Count - 1].Location.Y - 80);
                        break;
                    case 2:
                        platform = new PlatformMove(gameSize, platformList[platformList.Count - 1].Location.Y - 80);
                        break;
                    case 3:
                        platform = new PlatformDie(gameSize, platformList[platformList.Count - 1].Location.Y - 80);
                        break;
                    case 4:
                        platform = new PlatformJump(gameSize, platformList[platformList.Count - 1].Location.Y - 80);
                        break;
                    default:
                        platform = new Platform(gameSize, platformList[platformList.Count - 1].Location.Y - 80);
                        break;
                }
            }
            else
            {
                platform = new Platform(gameSize, platformList[platformList.Count - 1].Location.Y - 80);
            }
            platformList.Add(platform);
            gameForm.Controls.Add(platformList[platformList.Count - 1]);
            platform.BringToFront();

            if (shield != null)
            {
                shield.BringToFront();
            }
            BringToFront();
        }

        public void clearPlatforms()
        {
            platforms = null;
        }

        public void dellShield()
        {
            if (shield == null)
            {
                return;
            }
            gameForm.Controls.Remove(shield);
            shield.Dispose();
            shield = null;
        }

        private int GenerateRandomPlatform()
        {
            int platformType = 1;

            int rnd = random.Next(100);

            if (rnd == 99)
            {
                platformType = 4;
            }
            else if (rnd <= 70 && rnd >= 10)
            {
                platformType = 2;
            }
            else if (rnd <= 90 && rnd >= 75)
            {
                platformType = 3;
            }
            else
            {
                platformType = 1;
            }

            return platformType;
        }
        public void SetScore(int score)
        {
            Score = score;
        }
        public int ReadScore()
        {
            return Score;
        }
        public void movePlatform(Panel platform, int speed)
        {
            platform.Location = new Point(platform.Location.X, platform.Location.Y + speed);
        }
        public void SendPlatform(Panel platform)
        {
            this.platform = platform;
        }
        public void SendPlatforms(List<Panel> platforms)
        {
            this.platforms = platforms;
        }
        private void LeftSusl()
        {
            BackgroundImage = Properties.Resources.magician;

            List<Point> points = new List<Point>();
            points.Add(new Point(50, 88)); points.Add(new Point(48, 80)); points.Add(new Point(50, 88)); points.Add(new Point(43, 79));
            points.Add(new Point(39, 85)); points.Add(new Point(38, 74)); points.Add(new Point(33, 84)); points.Add(new Point(31, 74));
            points.Add(new Point(26, 85)); points.Add(new Point(25, 75)); points.Add(new Point(21, 75)); points.Add(new Point(20, 81));
            points.Add(new Point(18, 76)); points.Add(new Point(14, 85)); points.Add(new Point(12, 79)); points.Add(new Point(8, 88));
            points.Add(new Point(9, 78)); points.Add(new Point(19, 60)); points.Add(new Point(20, 47)); points.Add(new Point(2, 47));
            points.Add(new Point(1, 31)); points.Add(new Point(5, 27)); points.Add(new Point(12, 40)); points.Add(new Point(16, 35));
            points.Add(new Point(12, 29)); points.Add(new Point(18, 28)); points.Add(new Point(15, 22)); points.Add(new Point(16, 13));
            points.Add(new Point(18, 5)); points.Add(new Point(24, 1)); points.Add(new Point(38, 1)); points.Add(new Point(49, 7));
            points.Add(new Point(49, 18)); points.Add(new Point(47, 30)); points.Add(new Point(43, 36)); points.Add(new Point(49, 41));
            points.Add(new Point(51, 33)); points.Add(new Point(56, 26)); points.Add(new Point(60, 29)); points.Add(new Point(58, 34));
            points.Add(new Point(57, 47)); points.Add(new Point(41, 47)); points.Add(new Point(38, 45)); points.Add(new Point(39, 56));
            points.Add(new Point(42, 63)); points.Add(new Point(49, 71)); points.Add(new Point(51, 75)); points.Add(new Point(50, 88));
            using (GraphicsPath gp = new GraphicsPath())
            {
                gp.AddCurve(points.ToArray(), 0.7F);
                Region = new Region(gp);
            }
        }
        private void RightSusl()
        {
            BackgroundImage = Properties.Resources.magicianRight;

            List<Point> points = new List<Point>();
            points.Add(new Point(53,88)); points.Add(new Point(49,79)); points.Add(new Point(46,85)); points.Add(new Point(44,76));
            points.Add(new Point(40,81)); points.Add(new Point(39,74)); points.Add(new Point(36,75)); points.Add(new Point(35,85));
            points.Add(new Point(31,74)); points.Add(new Point(29,84)); points.Add(new Point(25,74)); points.Add(new Point(21,75));
            points.Add(new Point(22,85)); points.Add(new Point(18,78)); points.Add(new Point(15,88)); points.Add(new Point(13,80));
            points.Add(new Point(11,88)); points.Add(new Point(11,75)); points.Add(new Point(13,68)); points.Add(new Point(22,58));
            points.Add(new Point(23,51)); points.Add(new Point(23,46)); points.Add(new Point(19,48)); points.Add(new Point(3,47));
            points.Add(new Point(3,34)); points.Add(new Point(1,29)); points.Add(new Point(6,26)); points.Add(new Point(11,35));
            points.Add(new Point(13,41)); points.Add(new Point(18,36)); points.Add(new Point(13,25)); points.Add(new Point(12,16));
            points.Add(new Point(13,7)); points.Add(new Point(19,1)); points.Add(new Point(39,1)); points.Add(new Point(44,8));
            points.Add(new Point(46,15)); points.Add(new Point(45,23)); points.Add(new Point(44,29)); points.Add(new Point(50,29));
            points.Add(new Point(45,37)); points.Add(new Point(50,39)); points.Add(new Point(56,27)); points.Add(new Point(60,31));
            points.Add(new Point(58,47)); points.Add(new Point(43,46)); points.Add(new Point(42,54)); points.Add(new Point(47,66));
            points.Add(new Point(53,79)); points.Add(new Point(53,88));
            using (GraphicsPath gp = new GraphicsPath())
            {
                gp.AddCurve(points.ToArray(), 0.7F);
                Region = new Region(gp);
            }
        }
        public void OnLeft()
        {
            if (!left)
            {
                LeftSusl();
                left = true;
            }
            nowMoving = true;
        }
        public void OnRight()
        {
            if (left)
            {
                RightSusl();
                left = false;
            }
            nowMoving = true;
        }
        public void StopMove()
        {
            nowMoving = false;
        }
        public void StartJumping()
        {
            timer.Start();
        }
        public void StopJumping()
        {
            timer.Stop();
        }
        private void SuslMove()
        {
            if (left)
            {
                Location = new Point(Location.X - 7, Location.Y);
                if (Location.X <= -20)
                {
                    Location = new Point(gameSize.Width - Width + 20, Location.Y);
                }
            }
            else
            {
                Location = new Point(Location.X + 7, Location.Y);
                if (Location.X + Width >= gameSize.Width + 20)
                {
                    Location = new Point(-20, Location.Y);
                }
            }
        }
        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (shield != null)
            {
                shield.Location = new Point(Location.X - 45, Location.Y - 20);
                if (enemy != null && shield.Bounds.IntersectsWith(enemy.Bounds))
                {
                    gameForm.Controls.Remove(enemy);
                    enemy.Dispose();
                    enemy = null;
                    Coins++;
                    gameForm.Controls.Remove(shield);
                    shield.Dispose();
                    shield = null;
                    usingShield = false;
                }
            }
            if (spell != null)
            {
                spell.UseSpell();

                if (enemy != null && spell.Bounds.IntersectsWith(enemy.Bounds))
                {
                    gameForm.Controls.Remove(spell);
                    spell.Dispose();
                    spell = null;
                    enemy.HitBySpell(1);
                    if (enemy.GetHP() <= 0)
                    {
                        gameForm.Controls.Remove(enemy);
                        enemy.Dispose();
                        enemy = null;
                        Coins++;
                    }
                }
                else if (spell.Location.Y < 0)
                {
                    gameForm.Controls.Remove(spell);
                    spell.Dispose();
                    spell = null;
                }
            }
            if (enemy != null)
            {
                enemy.EnemyMove();
                if (Bounds.IntersectsWith(enemy.Bounds))
                {
                    gameForm.Controls.Remove(enemy);
                    enemy.Dispose();
                    enemy = null;
                    gameLose = true;
                }
            }
            if (gameLose)
            {
                LoseGame();
            }
            if (enemy == null && Score % 150 == 0 && Score != 0 && Score >= 1700 && jumpSpeed == 0)
            {
                if (random.Next(100) <= 15)
                {
                    enemy = new Enemy(gameSize);
                    gameForm.Controls.Add(enemy);
                    enemy.BringToFront();
                }
            }
            if (platforms != null)
            {
                foreach (var item in platforms)
                {
                    CheckPlatformType(item);
                    if (platformType == 3)
                    {
                        PlatformMove thisPlatform = (PlatformMove)item;
                        thisPlatform.StartMove();
                        if (Score >= 5000 && thisPlatform.Speed != 2)
                        {
                            thisPlatform.Speed = 2;
                        }
                        else if (Score >= 10000 && thisPlatform.Speed != 4)
                        {
                            thisPlatform.Speed = 4;
                        }
                    }
                }
            }
            if (nowMoving)
            {
                SuslMove();
            }
            if (jump && !gameLose)
            {
                if (tick <= 2)
                {
                    Location = new Point(Location.X, Location.Y + 1);
                }
                else if (tick <= 6)
                {
                    Location = new Point(Location.X, Location.Y + 2);
                }
                else if (tick <= 8)
                {
                    Location = new Point(Location.X, Location.Y + 4);
                }
                else if (tick <= 9)
                {
                    Location = new Point(Location.X, Location.Y + 5);
                }
                else if (!OnPlatform() && !gameLose)
                {
                    Location = new Point(Location.X, Location.Y + 9);
                }
                else
                {
                    jump = false;
                    tick = 0;
                }
            }
            else if (Location.Y <= (gameSize.Height / 2) - (Height / 3) && !gameLose)
            {
                Location = new Point(Location.X, (gameSize.Height / 2) - (Height / 3));
                if (tick <= 21 + jumpSpeed)
                {
                    movePlatforms(platforms, 9 + (jumpSpeed / 3));
                    moveEnemy(6 + (jumpSpeed / 3));
                }
                else if (tick <= 23 + jumpSpeed)
                {
                    movePlatforms(platforms, 8);
                    moveEnemy(5);
                }
                else if (tick <= 24 + jumpSpeed)
                {
                    movePlatforms(platforms, 5);
                    moveEnemy(2);
                }
                else if (tick <= 31 + jumpSpeed)
                {
                    movePlatforms(platforms, 2);
                    moveEnemy(1);
                }
                else if (tick <= 34 + jumpSpeed)
                {
                    movePlatforms(platforms, 1);
                    moveEnemy(1);
                }
                else
                {
                    movePlatforms(platforms, 1);
                    moveEnemy(1);
                    jump = true;
                    tick = 0;
                    jumpSpeed = 0;
                }
                Score++;
            }
            else if (!gameLose)
            {
                if (tick <= 6 + jumpSpeed)
                {
                    Location = new Point(Location.X, Location.Y - 10 - (jumpSpeed / 2));
                }
                else if (tick <= 21 + jumpSpeed)
                {
                    Location = new Point(Location.X, Location.Y - 8);
                }
                else if (tick <= 23 + jumpSpeed)
                {
                    Location = new Point(Location.X, Location.Y - 7);
                }
                else if (tick <= 24 + jumpSpeed)
                {
                    Location = new Point(Location.X, Location.Y - 5);
                }
                else if (tick <= 31 + jumpSpeed)
                {
                    Location = new Point(Location.X, Location.Y - 2);
                }
                else if (tick <= 34 + jumpSpeed)
                {
                    Location = new Point(Location.X, Location.Y - 1);
                }
                else
                {
                    Location = new Point(Location.X, Location.Y - 1);
                    jump = true;
                    tick = 0;
                    jumpSpeed = 0;
                }
            }
            tick++;
        }
        private bool OnPlatform()
        {
            bool onPlatform = false;
            if (platforms != null)
            {
                foreach (var item in platforms)
                {
                    if (Location.X + Width - 5 >= item.Location.X && Location.X + 5 <= item.Location.X + item.Width)
                    {
                        if (Location.Y + Height - 15 <= item.Location.Y && Location.Y + Height >= item.Location.Y + 5)
                        {
                            if (shield != null)
                            {
                                shield.BringToFront();
                            }
                            BringToFront();
                            onPlatform = true;
                            CheckPlatformType(item);
                            if (platformType == 2)
                            {
                                PlatformDie platform = (PlatformDie)item;
                                onPlatform = platform.IsDie == true ? false : true;
                                platform.Die();
                            }
                            else if (platformType == 4)
                            {
                                jumpSpeed = 30;
                            }
                            return onPlatform;
                        }
                    }
                }
            }
            else if (platform != null)
            {
                if (Location.X + Width - 5 >= platform.Location.X && Location.X + 5 <= platform.Location.X + platform.Width)
                {
                    if (Location.Y + Height - 15 <= platform.Location.Y && Location.Y + Height >= platform.Location.Y + 5)
                    {
                        onPlatform = true;
                        CheckPlatformType(platform);
                        if (platformType == 2)
                        {
                            PlatformDie platform = (PlatformDie)this.platform;
                            onPlatform = platform.IsDie == true ? false : true;
                            platform.Die();
                        }
                        else if (platformType == 4)
                        {
                            jumpSpeed = 30;
                        }
                        return onPlatform;
                    }
                }
            }
            return onPlatform;
        }
        private void CheckPlatformType(Panel thisPlatform)
        {
            if (thisPlatform.Name == "standart")
            {
                platformType = 1;
            }
            else if (thisPlatform.Name == "die")
            {
                platformType = 2;
            }
            else if (thisPlatform.Name == "move")
            {
                platformType = 3;
            }
            else if (thisPlatform.Name == "jump")
            {
                platformType = 4;
            }
        }
    }
}
