using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Susl_Jump.Items
{
    internal class Spell : PictureBox
    {
        public Spell(Point suslLocation)
        {
            Size = new Size(20,20);
            Image = Properties.Resources.spell;
            Location = new Point(suslLocation.X + 25, suslLocation.Y);

            using (GraphicsPath gp = new GraphicsPath())
            {
                gp.AddEllipse(0,0,20,20);
                Region = new Region(gp);
            }
        }
        public void UseSpell()
        {
            BringToFront();
            Location = new Point(Location.X, Location.Y - 10);
        }
    }
}
