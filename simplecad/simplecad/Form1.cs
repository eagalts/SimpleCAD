using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simplecad
{
    public partial class Form1 : Form
    {

        public enum SelectedTool
        {
            NO, LINE, DOT, RECT, CIRCLE, ARC
        };

        SelectedTool ST;

        float pos1X = 0, pos1Y = 0, pos2X = 0, pos2Y = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Paint(object sender, PaintEventArgs e) {}

        public void DrawLine(int penSize)
        {
            Graphics g = this.CreateGraphics();

            Pen pn = new Pen(Brushes.Blue, penSize);

            g.DrawLine(pn, pos1X, pos1Y, pos2X, pos2Y);

            g.Dispose();
        }

        
        public void DrawDot(int penSize)
        {
            Graphics g = this.CreateGraphics();

            Pen pn = new Pen(Brushes.Blue, penSize);

            g.DrawEllipse(pn, pos1X, pos1Y, penSize, penSize);
            
            g.Dispose();
        }
        
        public void DrawRectangular(int penSize)
        {
            Graphics g = this.CreateGraphics();

            Pen pn = new Pen(Brushes.Blue, penSize);

            float w = (pos2X - pos1X);
            float h = (pos2Y - pos1Y);

            if (w > 0 && h > 0)         g.DrawRectangle(pn, pos1X, pos1Y, w, h);
            else if (w < 0 && h > 0) g.DrawRectangle(pn, pos2X, pos1Y, Math.Abs(w), h);
            else if (w > 0 && h < 0) g.DrawRectangle(pn, pos1X, pos2Y, w, Math.Abs(h));
            else if (w < 0 && h < 0) g.DrawRectangle(pn, pos2X, pos2Y, Math.Abs(h), Math.Abs(h));

            g.Dispose();
        }

        public void DrawCircle(int penSize)
        {
            Graphics g = this.CreateGraphics();

            Pen pn = new Pen(Brushes.Blue, penSize);

            float w = (pos2X - pos1X);
            float h = (pos2Y - pos1Y);

            if (w > 0 && h > 0) g.DrawEllipse(pn, pos1X, pos1Y, w, h);
            else if (w < 0 && h > 0) g.DrawEllipse(pn, pos2X, pos1Y, Math.Abs(w), h);
            else if (w > 0 && h < 0) g.DrawEllipse(pn, pos1X, pos2Y, w, Math.Abs(h));
            else if (w < 0 && h < 0) g.DrawEllipse(pn, pos2X, pos2Y, Math.Abs(h), Math.Abs(h));

            g.Dispose();
        }
        public void DrawArc(int penSize)
        {
            Graphics g = this.CreateGraphics();

            Pen pn = new Pen(Brushes.Blue, penSize);

            float w = (pos2X - pos1X);
            float h = (pos2Y - pos1Y);

            if (w > 0 && h > 0) g.DrawArc(pn, pos1X, pos1Y, w, h, 90,180);
            else if (w < 0 && h > 0) g.DrawArc(pn, pos2X, pos1Y, Math.Abs(w), h,90,180);
            else if (w > 0 && h < 0) g.DrawArc(pn, pos1X, pos2Y, w, Math.Abs(h), 90,180);
            else if (w < 0 && h < 0) g.DrawArc(pn, pos2X, pos2Y, Math.Abs(h), Math.Abs(h), 90, 180);


            g.Dispose();
        }

        public void DrawTriangle(int penSize)
        {
            Graphics g = this.CreateGraphics();

            Pen pn = new Pen(Brushes.Blue, penSize);

            float w = (pos2X - pos1X);
            float h = (pos2Y - pos1Y);



            if (w > 0 && h > 0) g.DrawRectangle(pn, pos1X, pos1Y, w, h);
            else if (w < 0 && h > 0) g.DrawRectangle(pn, pos2X, pos1Y, Math.Abs(w), h);
            else if (w > 0 && h < 0) g.DrawRectangle(pn, pos1X, pos2Y, w, Math.Abs(h));
            else if (w < 0 && h < 0) g.DrawRectangle(pn, pos2X, pos2Y, Math.Abs(h), Math.Abs(h));

            g.Dispose();
        }




        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e){}
        
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            CursorStatus.Text = Convert.ToString(e.Location);
        }





        private void toolDotButton_Click(object sender, EventArgs e)
        {
            ST = SelectedTool.DOT;
            Deselect();
            toolDotButton.Checked = true;
        }

        public void Deselect()
        {
            toolLineButton.Checked = false;
            toolRectangularButton.Checked = false;
            toolEllipseButton.Checked = false;
            toolDotButton.Checked = false;
        }

        private void toolRectangularButton_Click(object sender, EventArgs e)
        {
            ST = SelectedTool.RECT;
            Deselect();
            toolRectangularButton.Checked = true;
        }

        private void toolEllipseButton_Click(object sender, EventArgs e)
        {
            ST = SelectedTool.CIRCLE;
            Deselect();
            toolEllipseButton.Checked = true;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);
            g.Dispose();
        }

        private void toolArcButton_Click(object sender, EventArgs e)
        {
            ST = SelectedTool.ARC;
            Deselect();
            toolArcButton.Checked = true;
        }

        private void Form1_Scroll(object sender, ScrollEventArgs e) {}

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e){}

        private void toolLineButton_Click(object sender, EventArgs e)
        {
            ST = SelectedTool.LINE;
            Deselect();
            toolLineButton.Checked = true;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (ST == SelectedTool.LINE)
            {
                if (pos1X == 0 && pos1Y == 0)
                {
                    pos1X = (e.X);
                    pos1Y = (e.Y);
                }

                else if (pos2X == 0 && pos2Y == 0)
                {
                    pos2X = (e.X);
                    pos2Y = (e.Y);

                    DrawLine(Convert.ToInt32(toolthickness.Text));

                    pos1X = 0; pos1Y = 0; pos2X = 0; pos2Y = 0;
                }
            }


            else if (ST == SelectedTool.DOT)
            {
                pos1X = (e.X);
                pos1Y = (e.Y);

                DrawDot(Convert.ToInt32(toolthickness.Text));
                pos1X = 0; pos1Y = 0; pos2X = 0; pos2Y = 0;
            }


            else if (ST == SelectedTool.RECT)
            {
                if (pos1X == 0 && pos1Y == 0)
                {
                    pos1X = (e.X);
                    pos1Y = (e.Y);
                }

                else if (pos2X == 0 && pos2Y == 0)
                {
                    pos2X = (e.X);
                    pos2Y = (e.Y);

                    DrawRectangular(Convert.ToInt32(toolthickness.Text));

                    pos1X = 0; pos1Y = 0; pos2X = 0; pos2Y = 0;
                }
            }

            else if (ST == SelectedTool.CIRCLE)
            {
                if (pos1X == 0 && pos1Y == 0)
                {
                    pos1X = (e.X);
                    pos1Y = (e.Y);
                }

                else if (pos2X == 0 && pos2Y == 0)
                {
                    pos2X = (e.X);
                    pos2Y = (e.Y);

                    DrawCircle(Convert.ToInt32(toolthickness.Text));

                    pos1X = 0; pos1Y = 0; pos2X = 0; pos2Y = 0;
                }
            }

            else if (ST == SelectedTool.ARC)
            {
                if (pos1X == 0 && pos1Y == 0)
                {
                    pos1X = (e.X);
                    pos1Y = (e.Y);
                }

                else if (pos2X == 0 && pos2Y == 0)
                {
                    pos2X = (e.X);
                    pos2Y = (e.Y);

                    DrawArc(Convert.ToInt32(toolthickness.Text));

                    pos1X = 0; pos1Y = 0; pos2X = 0; pos2Y = 0;
                }
            }
        }
    }
}
