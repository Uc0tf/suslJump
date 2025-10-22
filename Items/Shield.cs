using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Susl_Jump.Items
{
    internal class Shield : Panel
    {
        public Shield(Point suslLocation)
        {
            Size = new Size(150, 110);
            BackColor = Color.DeepSkyBlue;
            Location = new Point(suslLocation.X - 45, suslLocation.Y - 20);

            List<Point> points = new List<Point>();
            points.Add(new Point(0, 100)); points.Add(new Point(75, 0)); points.Add(new Point(150, 100));
            points.Add(new Point(145, 95)); points.Add(new Point(75, 5)); points.Add(new Point(5, 95));
            using (GraphicsPath gp = new GraphicsPath())
            {
                gp.AddCurve(points.ToArray(), 1F);
                Region = new Region(gp);
            }
        }
    }
}
