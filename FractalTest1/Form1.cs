using System;
using System.Diagnostics;
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

            fractal = new MandelbrotFractal(WIDTH, HEIGHT);
            Render();
        }

        void Render()
        {
            pictureBox1.Image = fractal.Render();
        }

        /*void Output(string message)
        {
            outputTextBox.AppendText(message);
            outputTextBox.AppendText(Environment.NewLine);
        }*/

        private void zoomInBtn_Click(object sender, EventArgs e)
        {
            double wh = fractal.upperY - fractal.lowerY;
            fractal.lowerX += wh / 5;
            fractal.upperX -= wh / 5;

            fractal.lowerY += wh / 5;
            fractal.upperY -= wh / 5;

            Render();
        }

        private void zoomOutBtn_Click(object sender, EventArgs e)
        {
            double wh = fractal.upperY - fractal.lowerY;
            fractal.lowerX -= wh / 5;
            fractal.upperX += wh / 5;

            fractal.lowerY -= wh / 5;
            fractal.upperY += wh / 5;

            Render();
        }

        private void moveUpBtn_Click(object sender, EventArgs e)
        {
            double wh = fractal.upperY - fractal.lowerY;
            if (fractal.flippedY)
            {
                fractal.lowerY -= wh / 5;
                fractal.upperY -= wh / 5;
            }
            else
            {
                fractal.lowerY += wh / 5;
                fractal.upperY += wh / 5;
            }
            
            Render();
        }

        private void moveDownBtn_Click(object sender, EventArgs e)
        {
            double wh = fractal.upperY - fractal.lowerY;

            if (fractal.flippedY)
            {
                fractal.lowerY += wh / 5;
                fractal.upperY += wh / 5;
            }
            else
            {
                fractal.lowerY -= wh / 5;
                fractal.upperY -= wh / 5;
            }

            Render();
        }

        private void moveLeftBtn_Click(object sender, EventArgs e)
        {
            double wh = fractal.upperY - fractal.lowerY;
            fractal.lowerX -= wh / 5;
            fractal.upperX -= wh / 5;
            Render();
        }

        private void moveRightBtn_Click(object sender, EventArgs e)
        {
            double wh = fractal.upperY - fractal.lowerY;
            fractal.lowerX += wh / 5;
            fractal.upperX += wh / 5;
            Render();
        }

        private void mandelbrotBtn_Click(object sender, EventArgs e)
        {
            GC.Collect();
            fractal = new MandelbrotFractal(WIDTH, HEIGHT);
            Render();
        }

        private void burningShipBtn_Click(object sender, EventArgs e)
        {
            GC.Collect();
            fractal = new BurningShipFractal(WIDTH, HEIGHT);
            Render();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = e as MouseEventArgs;

            int dx = me.X - WIDTH / 2;
            int dy = HEIGHT / 2 - me.Y;

            double diffX, diffY;
            diffX = ((double)dx / WIDTH) * (fractal.upperX - fractal.lowerX);
            diffY = ((double)dy / HEIGHT) * (fractal.upperY - fractal.lowerY);

            fractal.lowerX += diffX;
            fractal.upperX += diffX;

            if (fractal.flippedY)
            {
                fractal.lowerY -= diffY;
                fractal.upperY -= diffY;
            }
            else
            {
                fractal.lowerY += diffY;
                fractal.upperY += diffY;
            }

            Render();
        }
    }
}
