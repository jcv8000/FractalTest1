using System;
using System.Drawing;
using System.Windows.Forms;

namespace FractalTest1
{
    public partial class Form1 : Form
    {

        const int WIDTH = 720;
        const int HEIGHT = 720;

        Fractal fractal;

        public Form1()
        {
            InitializeComponent();

            fractal = new CustomFractal1(WIDTH, HEIGHT);
            pictureBox1.Image = fractal.Render();
        }

        private void zoomInBtn_Click(object sender, EventArgs e)
        {
            double wh = fractal.upperY - fractal.lowerY;
            fractal.lowerX += wh / 5;
            fractal.upperX -= wh / 5;

            fractal.lowerY += wh / 5;
            fractal.upperY -= wh / 5;

            pictureBox1.Image = fractal.Render();
        }

        private void zoomOutBtn_Click(object sender, EventArgs e)
        {
            double wh = fractal.upperY - fractal.lowerY;
            fractal.lowerX -= wh / 5;
            fractal.upperX += wh / 5;

            fractal.lowerY -= wh / 5;
            fractal.upperY += wh / 5;

            pictureBox1.Image = fractal.Render();
        }

        private void moveUpBtn_Click(object sender, EventArgs e)
        {
            double wh = fractal.upperY - fractal.lowerY;
            fractal.lowerY += wh / 5;
            fractal.upperY += wh / 5;
            pictureBox1.Image = fractal.Render();
        }

        private void moveDownBtn_Click(object sender, EventArgs e)
        {
            double wh = fractal.upperY - fractal.lowerY;
            fractal.lowerY -= wh / 5;
            fractal.upperY -= wh / 5;
            pictureBox1.Image = fractal.Render();
        }

        private void moveLeftBtn_Click(object sender, EventArgs e)
        {
            double wh = fractal.upperY - fractal.lowerY;
            fractal.lowerX -= wh / 5;
            fractal.upperX -= wh / 5;
            pictureBox1.Image = fractal.Render();
        }

        private void moveRightBtn_Click(object sender, EventArgs e)
        {
            double wh = fractal.upperY - fractal.lowerY;
            fractal.lowerX += wh / 5;
            fractal.upperX += wh / 5;
            pictureBox1.Image = fractal.Render();
        }

        private void mandelbrotBtn_Click(object sender, EventArgs e)
        {
            GC.Collect();
            fractal = new MandelbrotFractal(WIDTH, HEIGHT);
            pictureBox1.Image = fractal.Render();
        }

        private void burningShipBtn_Click(object sender, EventArgs e)
        {
            GC.Collect();
            fractal = new BurningShipFractal(WIDTH, HEIGHT);
            pictureBox1.Image = fractal.Render();
        }
    }
}
