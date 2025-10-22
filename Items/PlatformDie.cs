using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

namespace Susl_Jump.Items
{
    internal class PlatformDie : Panel
    {
        Random random = new Random();
        public bool IsDie { get; set; }
        public PlatformDie(Size gameSize)
        {
            IsDie = false;
            Name = "die";
            Width = 60;
            Height = 15;

            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = Size;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Image = Properties.Resources.platformDie;

            Controls.Add(pictureBox);

            BackColor = Color.FloralWhite;
            Location = new Point(random.Next(5, gameSize.Width - Width - 5), -Height);
            CreateRegion();
        }
        public PlatformDie(Size gameSize, int Height)
        {
            IsDie = false;
            Name = "die";
            Width = 60;
            this.Height = 15;

            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = Size;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Image = Properties.Resources.platformDie;

            Controls.Add(pictureBox);

            BackColor = Color.FloralWhite;
            Location = new Point(random.Next(5, gameSize.Width - Width - 5), Height - this.Height);
            CreateRegion();
        }
        public void Die()
        {
            IsDie = true;
            Visible = false;
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
