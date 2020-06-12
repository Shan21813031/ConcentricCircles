using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcentricCircles

    /// This program draws out 10 circles decreasing in size
    /// Author: Shan Ahmed
    /// Task 6.5
{
    public partial class ConcentricCircles : Form
    {
        public const int MAXCOLOUR = 256;
        private Random generate = new Random();
        private Brush myBrush;

        public ConcentricCircles()
        {
            InitializeComponent();
        }

        /// <summary>
        /// random number assigned to each value in RGB to create random colour
        /// </summary>
        /// <returns></returns>

        private Color randomColor()
        {
            int r, g, b;
            r = generate.Next(MAXCOLOUR);
            g = generate.Next(MAXCOLOUR);
            b = generate.Next(MAXCOLOUR);
            return Color.FromArgb(r, g, b);

        }

        private void ConcentricCircles_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Creates a circle 10 times in a different colour
        /// decreasing in size
        /// </summary>

        private void ConcentricCircles_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Color color = randomColor();
            this.BackColor = Color.Black;
            int x = 100, y = 50, size = 300;

            for (int count = 0; count < 10; count++)
            {
                Pen myPen = new Pen(randomColor(), 10);
                myBrush = new SolidBrush(randomColor());
                g.FillEllipse(myBrush, x, y, size, size);
                g.DrawEllipse(myPen, x, y, size, size);
                x = x + 15;
                y = y + 15;
                size = size - 30;
                
            }
        }
    }
}
