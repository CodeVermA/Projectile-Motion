using System.Drawing;
using System.Windows.Forms;

namespace Projectile_Motion___Final_Year
{
    public class Board
    {
        PictureBox picBox;
        Pen myPen = new Pen(Color.Black);
        SolidBrush brush = new SolidBrush(Color.Black);
        Graphics graphics;

        public Board(PictureBox picbox)
        {
            picBox = picbox;
            graphics = picBox.CreateGraphics();// Get Access to draw graphics on Picture Box
        }

        public void Clear()
        {
            graphics.Clear(SystemColors.Control);//Whiten the whole Board
        }

        public void ResetPictureBox(PictureBox picbox)
        {
            picBox = picbox;
            graphics = picBox.CreateGraphics();// Get Access to draw graphics on Picture Box
        }

        public void DrawGraph(int s, int width, int height)
        {
            Clear();

            for (int x = 0; x < width; x = x + s)
            {
                for (int y = height; y > -s ; y = y - s)
                {
                    graphics.DrawRectangle(myPen, new Rectangle(x, y, s, s));// Draws Rectangles
                }
            }
        }
        public void DrawCurve(PointF[] points)
        {
            myPen.Width = 2;
            graphics.DrawCurve(myPen, points);// Draws Curve
            myPen.Width = 1;
        }

        public void FillCircle(float x, float y)
        {
            int ballHeight = 12, ballWidth = 12;
            x -= ballWidth / 2;
            y -= ballHeight;
            graphics.FillEllipse(brush, x, y, ballWidth, ballHeight);
        }
    }
}
