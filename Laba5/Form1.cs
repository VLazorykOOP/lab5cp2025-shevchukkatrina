using System;
using System.Drawing;
using System.Windows.Forms;

namespace FractalsAndHermite
{
    public partial class Form1 : Form
    {
        private PointF P1 = new PointF(100, 400);
        private PointF P2 = new PointF(600, 200);
        private PointF V1 = new PointF(200, -300);
        private PointF V2 = new PointF(200, 300);
        private float t = 0f;
        private Timer hermiteTimer;
        private Bitmap hermiteBuffer;
        private Bitmap kochBuffer;

        public Form1()
        {
            InitializeComponent();

            hermiteTimer = new Timer();
            hermiteTimer.Interval = 30;
            hermiteTimer.Tick += HermiteTimer_Tick;

            hermiteBuffer = new Bitmap(pictureBoxHermite.Width, pictureBoxHermite.Height);
            kochBuffer = new Bitmap(pictureBoxKoch.Width, pictureBoxKoch.Height);
        }

        private void btnHermiteStart_Click(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(hermiteBuffer))
                g.Clear(Color.White);
            t = 0f;
            hermiteTimer.Start();
        }

        private void HermiteTimer_Tick(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(hermiteBuffer))
            {
                Pen curvePen = new Pen(Color.Blue, 2);
                PointF p1 = Hermite(P1, P2, V1, V2, t);
                PointF p2 = Hermite(P1, P2, V1, V2, t + 0.01f);
                g.DrawLine(curvePen, p1, p2);
            }
            t += 0.01f;
            if (t >= 1f) hermiteTimer.Stop();
            pictureBoxHermite.Invalidate();
        }

        private PointF Hermite(PointF p1, PointF p2, PointF v1, PointF v2, float t)
        {
            float t2 = t * t;
            float t3 = t2 * t;
            float h1 = 2 * t3 - 3 * t2 + 1;
            float h2 = -2 * t3 + 3 * t2;
            float h3 = t3 - 2 * t2 + t;
            float h4 = t3 - t2;
            float x = h1 * p1.X + h2 * p2.X + h3 * v1.X + h4 * v2.X;
            float y = h1 * p1.Y + h2 * p2.Y + h3 * v1.Y + h4 * v2.Y;
            return new PointF(x, y);
        }

        private void pictureBoxHermite_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(hermiteBuffer, 0, 0);
            e.Graphics.FillEllipse(Brushes.Red, P1.X - 4, P1.Y - 4, 8, 8);
            e.Graphics.FillEllipse(Brushes.Red, P2.X - 4, P2.Y - 4, 8, 8);
            DrawVector(e.Graphics, P1, V1, Color.Green);
            DrawVector(e.Graphics, P2, V2, Color.Orange);
        }

        private void DrawVector(Graphics g, PointF basePoint, PointF vector, Color color)
        {
            Pen pen = new Pen(color, 1);
            pen.CustomEndCap = new System.Drawing.Drawing2D.AdjustableArrowCap(5, 5);
            PointF end = new PointF(basePoint.X + vector.X / 3, basePoint.Y + vector.Y / 3);
            g.DrawLine(pen, basePoint, end);
        }

        private void btnDrawKoch_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtD.Text, out int D)) D = 400;
            if (!int.TryParse(txtK.Text, out int K)) K = 3;

            using (Graphics g = Graphics.FromImage(kochBuffer))
            {
                g.Clear(Color.White);
                int cx = pictureBoxKoch.Width / 2;
                int cy = pictureBoxKoch.Height / 2;

                PointF p1 = new PointF(cx - D / 2f, cy - D / 2f);
                PointF p2 = new PointF(cx + D / 2f, cy - D / 2f);
                PointF p3 = new PointF(cx + D / 2f, cy + D / 2f);
                PointF p4 = new PointF(cx - D / 2f, cy + D / 2f);

                Pen pen = new Pen(Color.Blue, 1);

                DrawKoch(g, pen, p1, p2, K);
                DrawKoch(g, pen, p2, p3, K);
                DrawKoch(g, pen, p3, p4, K);
                DrawKoch(g, pen, p4, p1, K);
            }

            pictureBoxKoch.Invalidate();
        }

        private void pictureBoxKoch_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(kochBuffer, 0, 0);
        }

        private void DrawKoch(Graphics g, Pen pen, PointF a, PointF b, int order)
        {
            if (order == 0)
            {
                g.DrawLine(pen, a, b);
                return;
            }

            PointF p1 = a;
            PointF p5 = b;
            PointF p2 = new PointF((2 * p1.X + p5.X) / 3, (2 * p1.Y + p5.Y) / 3);
            PointF p4 = new PointF((p1.X + 2 * p5.X) / 3, (p1.Y + 2 * p5.Y) / 3);
            double angle = Math.Atan2(p5.Y - p1.Y, p5.X - p1.X) - Math.PI / 3;
            double dist = Distance(p2, p4);
            PointF p3 = new PointF((float)(p2.X + Math.Cos(angle) * dist), (float)(p2.Y + Math.Sin(angle) * dist));

            DrawKoch(g, pen, p1, p2, order - 1);
            DrawKoch(g, pen, p2, p3, order - 1);
            DrawKoch(g, pen, p3, p4, order - 1);
            DrawKoch(g, pen, p4, p5, order - 1);
        }

        private double Distance(PointF p1, PointF p2)
        {
            double dx = p2.X - p1.X;
            double dy = p2.Y - p1.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}