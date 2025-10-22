using System.Drawing.Drawing2D;

namespace Susl_Jump.Items
{
    internal class userNameLabel : Label
    {
        public userNameLabel()
        {
            ForeColor = Color.White;
            BackColor = Color.Black;
            Text = "guest";
            AutoSize = false;
            Font = new Font("Lucida Sans", 7);
            Size = new Size(130, 30);
            TextAlign = ContentAlignment.MiddleCenter;
            BorderStyle = BorderStyle.FixedSingle;
            Location = new Point(0, 650);
        }
    }
}
