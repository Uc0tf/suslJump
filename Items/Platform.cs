using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Susl_Jump.Items
{
    internal class Platform : Panel
    {
        Random random = new Random();
        public Platform(Size gameSize)
        {
            Name = "standart";
            Width = 60;
            Height = 15;
            BackgroundImage = Properties.Resources.platformStandart;
            Location = new Point(random.Next(5, gameSize.Width - Width - 5), -Height);
            CreateRegion();
        }
        public Platform(Size gameSize, int Height)
        {
            Name = "standart";
            Width = 60;
            this.Height = 15;
            BackgroundImage = Properties.Resources.platformStandart;
            Location = new Point(random.Next(5, gameSize.Width - Width - 5), Height - this.Height);
            CreateRegion();
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
