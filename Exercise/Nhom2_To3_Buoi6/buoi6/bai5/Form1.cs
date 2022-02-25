using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai5
{
    public partial class Form1 : Form
    {
        private Color fill;
        private Color border;
        private bool mouse_is_down = false;
        private Point start;
        private Graphics g;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = Panel.CreateGraphics();
            border = Color.Black;
            btnChoseColorBorder.BackColor = border;
            fill = Color.Red;
            btnChoseColorFill.BackColor = fill;
        }

        private void btnChoseColorBorder_Click(object sender, EventArgs e)
        {
            ColorDialog clo = new ColorDialog();
            clo.FullOpen = true;
            clo.AnyColor = true;
            if(clo.ShowDialog() == DialogResult.OK)
            {
                btnChoseColorBorder.BackColor = clo.Color;
                border = clo.Color;
            }
        }

        private void btnChoseColorFill_Click(object sender, EventArgs e)
        {
            ColorDialog clo = new ColorDialog();
            clo.FullOpen = true;
            clo.AnyColor = true;
            if (clo.ShowDialog() == DialogResult.OK)
            {
                btnChoseColorFill.BackColor = clo.Color;
                fill = clo.Color;
            }
        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_is_down = true;
            start = new Point(e.X, e.Y);
        }

        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            mouse_is_down = false;
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse_is_down)
            {
                g.Clear(Panel.BackColor);
                Point end = new Point(e.X, e.Y);
                switch (cbChoseType.SelectedIndex)
                {
                    case 0:
                        {
                            g.DrawLine(new Pen(border, (int)nmSize.Value), start, end);
                            break;
                        }
                    case 1:
                        {
                            g.DrawEllipse(new Pen(border, (int)nmSize.Value), start.X, start.Y, e.X - start.X, e.Y - start.Y);
                            break;
                        }
                    case 2:
                        {
                            g.DrawEllipse(new Pen(border, (int)nmSize.Value), start.X, start.Y, e.X - start.X, e.Y - start.Y);
                            g.FillEllipse(new SolidBrush(fill), start.X, start.Y, e.X - start.X, e.Y - start.Y);
                            break;
                        }
                    case 3:
                        {
                            g.DrawRectangle(new Pen(border, (int)nmSize.Value), start.X, start.Y, e.X - start.X, e.Y - start.Y);
                            break;
                        }
                    case 4:
                        {
                            g.DrawRectangle(new Pen(border, (int)nmSize.Value), start.X, start.Y, e.X - start.X, e.Y - start.Y);
                            g.FillRectangle(new SolidBrush(fill), start.X, start.Y, e.X - start.X, e.Y - start.Y);
                            break;
                        }
                }
            }
        }
    }
}
