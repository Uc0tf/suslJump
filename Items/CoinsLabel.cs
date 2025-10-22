using System.Drawing.Drawing2D;

namespace Susl_Jump.Items
{
    internal class CoinsLabel : Label
    {
        public CoinsLabel()
        {
            ForeColor = Color.Gold;
            BackColor = Color.Black;
            Text = "0 💰";
            AutoSize = false;
            Size = new Size(130, 30);
            TextAlign = ContentAlignment.MiddleCenter;
            BorderStyle = BorderStyle.FixedSingle;
            Location = new Point(10, 45);
        }
    }
}
