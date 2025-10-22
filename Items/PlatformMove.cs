using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

namespace Susl_Jump.Items
{
    internal class PlatformMove : Panel
    {
        Random random = new Random();
        bool left;
        Size gameSize;
        public int Speed { get; set; }
        public PlatformMove(Size gameSize)
        {
            Name = "move";
            Width = 60;
            Height = 15;
            Location = new Point(random.Next(5, gameSize.Width - Width - 5), -Height);
            CreateRegion();

            Speed = 1;

            this.gameSize = gameSize;
            left = false;

            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = Size;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Image = Properties.Resources.platformStandart;

            Controls.Add(pictureBox);
        }
        public PlatformMove(Size gameSize, int Height)
        {
            Name = "move";
            Width = 60;
            this.Height = 15;
            BackgroundImage = Properties.Resources.platformStandart;
            Location = new Point(random.Next(5, gameSize.Width - Width - 5), Height - this.Height);
            CreateRegion();

            Speed = 1;

            this.gameSize = gameSize;
            left = false;

            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = Size;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Image = Properties.Resources.platformStandart;

            Controls.Add(pictureBox);
        }
        public void StartMove()
        {
            WallControl();
            if (left)
            {
                Location = new Point(Location.X - Speed, Location.Y);
            }
            else
            {
                Location = new Point(Location.X + Speed, Location.Y);
            }
        }
        private void WallControl()
        {
            if (left)
            {
                if (Location.X - 5 <= 5)
                {
                    left = false;
                }
            }
            else
            {
                if (Location.X + 5 >= gameSize.Width - Width - 5)
                {
                    left = true;
                }
            }
        }
        private void CreateRegion()
        {
            List<Point> points = new List<Point>();
            points.Add(new Point(30, 0)); points.Add(new Point(60, 8)); points.Add(new Point(30, 16)); points.Add(new Point(0, 8));
            using (GraphicsPath gp = new GraphicsPath())
            {
                gp.AddClosedCurve(points.ToArray(), 1.15F);
                Region = new Region(gp);
            }
        }
    }
}
