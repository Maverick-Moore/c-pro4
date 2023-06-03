using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace DrawLine
{
    public partial class Form1 : Form
    {
        HatchBrush hatchBrush;
        int drawOptions = 0;
        Pen pen1;
        Rectangle rectangle1;
        Rectangle rectangle2;
        Point[] polygonPoints = new Point[6];
        String TextToDraw;
        Font chosenFont;
        SolidBrush solidBrush;
        StringFormat stringFormat;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pen1 = new Pen(Color.LightPink, 10);
            drawOptions = 1;
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            switch (drawOptions)
            {

                case 1:

                    e.Graphics.DrawLine(pen1, 100, 100, 200, 300);
                    break;

                case 2:

                    e.Graphics.DrawRectangle(pen1, rectangle1);
                    e.Graphics.FillRectangle(Brushes.Blue, rectangle1);
                    break;

                case 3:
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    e.Graphics.DrawEllipse(pen1, rectangle2);
                    e.Graphics.FillEllipse(Brushes.LightPink, rectangle2);
                    break;

                case 4:

                    e.Graphics.DrawPolygon(Pens.Black, polygonPoints);
                    e.Graphics.FillPolygon(hatchBrush, polygonPoints);
                    break;

                case 5:

                    e.Graphics.DrawString(TextToDraw, chosenFont, solidBrush, 100, 10, stringFormat);
                    break;

                default:

                    break;

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            drawOptions = 0;
            Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rectangle1 = new Rectangle(10, 10, 100, 300);
            pen1 = new Pen(Color.Blue, 1);
            drawOptions = 2;
            Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rectangle2 = new Rectangle(10, 10, 150, 100);
            pen1 = new Pen(Color.DarkBlue, 2);
            drawOptions = 3;
            Invalidate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            polygonPoints[0] = new Point(50, 150);
            polygonPoints[1] = new Point(20, 65);
            polygonPoints[2] = new Point(100, 10);
            polygonPoints[3] = new Point(175, 65);
            polygonPoints[4] = new Point(150, 150);
            polygonPoints[5] = new Point(50, 150);
            hatchBrush = new HatchBrush(HatchStyle.BackwardDiagonal, Color.DarkCyan, Color.Aqua);
            drawOptions = 4;
            Invalidate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TextToDraw = "Yurr.";
            chosenFont = new Font("Arial", 20, FontStyle.Bold);
            solidBrush = new SolidBrush(Color.Black);
            stringFormat = new StringFormat(StringFormatFlags.DirectionVertical);
            drawOptions = 5;
            Invalidate();
        }
    }
}
