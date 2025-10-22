using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Susl_Jump.Items
{
    internal class ScoreLabel : Label
    {
        public ScoreLabel()
        {
            ForeColor = Color.White;
            BackColor = Color.Black;
            Text = "0";
            AutoSize = false;
            Size = new Size(150, 30);
            TextAlign = ContentAlignment.MiddleCenter;
            BorderStyle = BorderStyle.FixedSingle;
            Location = new Point(10, 10); 
        }
    }
}
