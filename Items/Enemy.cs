using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Susl_Jump.Items
{
    internal class Enemy : PictureBox
    {
        Random random = new Random();
        bool left;
        int tick = 0;
        int HP { get; set; }
        public Enemy(Size gameSize)
        {
            Name = "enemy";
            HP = 3;
            Width = 80;
            Height = 80;
            Image = Properties.Resources.eyeMonster;
            Location = new Point(random.Next(30, gameSize.Width - Width - 30), -Height);
            CreateRegion();
        }
        private void CreateRegion()
        {
            using (GraphicsPath gp = new GraphicsPath())
            {
                gp.AddEllipse(0, 0, 80, 80);
                Region = new Region(gp);
            }
        }
        public void HitBySpell(int spellType)
        {
            HP -= spellType;
            Image = Properties.Resources.eyeMonsterHit;
        }
        public int GetHP()
        {
            return HP;
        }
        public void EnemyMove()
        {
            tick++;
            if (left && tick % 4 == 0)
            {
                Location = new Point(Location.X - 1, Location.Y);
                if (tick == 32)
                {
                    left = false;
                    tick = 0;
                }
            }
            else if(!left && tick % 4 == 0)
            {
                Location = new Point(Location.X + 1, Location.Y);
                if (tick == 32)
                {
                    left = true;
                    tick = 0;
                }
            }
        }
    }
}
