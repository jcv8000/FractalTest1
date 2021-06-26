using System;
using System.Drawing;
using System.Windows.Forms;

namespace FractalTest1
{
    public partial class Form1 : Form
    {

        const int WIDTH = 720;
        const int HEIGHT = 720;
        const double BREAKPOINT = 2.0;
        const int ITERATIONS = 100;

        double lowerX = -3.0;
        double upperX = 3.0;
        double lowerY = -3.0;
        double upperY = 3.0;

        Bitmap img;

        delegate void Renderer();
        Renderer render;

        public Form1()
        {
            InitializeComponent();

            img = new Bitmap(WIDTH, HEIGHT);

            // THIS SETS THE FRACTAL TO USE
            render = RenderBurningShip;
            // THIS SETS THE FRACTAL TO USE

            render();
        }

        public void RenderMandelbrot()
        {

            for (int px = 0; px < WIDTH; px++)
            {
                // Scaled
                double x = lowerX + (((double)px / WIDTH) * (upperX - lowerX));

                for (int py = 0; py < HEIGHT; py++)
                {
                    double y = upperY - (((double)py / HEIGHT) * (upperY - lowerY));

                    Color color = Color.White;

                    double newX = x;
                    double newY = y;

                    int i;
                    for (i = 0; i < ITERATIONS; i++)
                    {
                        double xtemp = newX;
                        double ytemp = newY;
                        newX = (xtemp * xtemp) - (ytemp * ytemp) + x;
                        newY = (2 * xtemp * ytemp) + y;

                        double distance = Math.Sqrt((newX * newX) + (newY * newY));
                        if (distance >= BREAKPOINT)
                        {
                            break;
                        }
                    }

                    color = Color.Black;
                    if (i >= 0 && i < ITERATIONS)
                    {
                        int r, g, b;
                        HsvToRgb(((double)i / ITERATIONS) * 360, 1, 1, out r, out g, out b);
                        color = Color.FromArgb(r, g, b);
                    }

                    img.SetPixel(px, py, color);
                }
            }

            // Update image
            pictureBox1.Image = img;
        }

        public void RenderBurningShip()
        {

            for (int px = 0; px < WIDTH; px++)
            {
                // Scaled
                double x = lowerX + (((double)px / WIDTH) * (upperX - lowerX));

                for (int py = 0; py < HEIGHT; py++)
                {
                    double y = lowerY + (((double)py / HEIGHT) * (upperY - lowerY));

                    Color color = Color.White;

                    double newX = x;
                    double newY = y;

                    int i;
                    for (i = 0; i < ITERATIONS; i++)
                    {
                        double xtemp = Math.Abs(newX);
                        double ytemp = Math.Abs(newY);
                        newX = (xtemp * xtemp) - (ytemp * ytemp) + x;
                        newY = (2 * xtemp * ytemp) + y;

                        double distance = Math.Sqrt((newX * newX) + (newY * newY));
                        if (distance >= BREAKPOINT)
                        {
                            break;
                        }
                    }

                    color = Color.Black;
                    if (i >= 0 && i < ITERATIONS)
                    {
                        //int r, g, b;
                        //HsvToRgb(((double)i / ITERATIONS) * 360, 1, 1, out r, out g, out b);
                        int brightness = 255 - (int)(((double)i / ITERATIONS) * 255);
                        color = Color.FromArgb(brightness, brightness, brightness);
                    }

                    img.SetPixel(px, py, color);
                }
            }

            // Update image
            pictureBox1.Image = img;
        }

        private void zoomInBtn_Click(object sender, EventArgs e)
        {
            double wh = upperY - lowerY;
            lowerX += wh / 5;
            upperX -= wh / 5;

            lowerY += wh / 5;
            upperY -= wh / 5;

            render();
        }

        private void zoomOutBtn_Click(object sender, EventArgs e)
        {
            double wh = upperY - lowerY;
            lowerX -= wh / 5;
            upperX += wh / 5;

            lowerY -= wh / 5;
            upperY += wh / 5;

            render();
        }

        private void moveUpBtn_Click(object sender, EventArgs e)
        {
            double wh = upperY - lowerY;
            lowerY += wh / 5;
            upperY += wh / 5;
            render();
        }

        private void moveDownBtn_Click(object sender, EventArgs e)
        {
            double wh = upperY - lowerY;
            lowerY -= wh / 5;
            upperY -= wh / 5;
            render();
        }

        private void moveLeftBtn_Click(object sender, EventArgs e)
        {
            double wh = upperY - lowerY;
            lowerX -= wh / 5;
            upperX -= wh / 5;
            render();
        }

        private void moveRightBtn_Click(object sender, EventArgs e)
        {
            double wh = upperY - lowerY;
            lowerX += wh / 5;
            upperX += wh / 5;
            render();
        }

        /// <summary>
        /// Convert HSV to RGB
        /// h is from 0-360
        /// s,v values are 0-1
        /// r,g,b values are 0-255
        /// Based upon http://ilab.usc.edu/wiki/index.php/HSV_And_H2SV_Color_Space#HSV_Transformation_C_.2F_C.2B.2B_Code_2
        /// </summary>
        void HsvToRgb(double h, double S, double V, out int r, out int g, out int b)
        {
            // ######################################################################
            // T. Nathan Mundhenk
            // mundhenk@usc.edu
            // C/C++ Macro HSV to RGB

            double H = h;
            while (H < 0) { H += 360; };
            while (H >= 360) { H -= 360; };
            double R, G, B;
            if (V <= 0)
            { R = G = B = 0; }
            else if (S <= 0)
            {
                R = G = B = V;
            }
            else
            {
                double hf = H / 60.0;
                int i = (int)Math.Floor(hf);
                double f = hf - i;
                double pv = V * (1 - S);
                double qv = V * (1 - S * f);
                double tv = V * (1 - S * (1 - f));
                switch (i)
                {

                    // Red is the dominant color

                    case 0:
                        R = V;
                        G = tv;
                        B = pv;
                        break;

                    // Green is the dominant color

                    case 1:
                        R = qv;
                        G = V;
                        B = pv;
                        break;
                    case 2:
                        R = pv;
                        G = V;
                        B = tv;
                        break;

                    // Blue is the dominant color

                    case 3:
                        R = pv;
                        G = qv;
                        B = V;
                        break;
                    case 4:
                        R = tv;
                        G = pv;
                        B = V;
                        break;

                    // Red is the dominant color

                    case 5:
                        R = V;
                        G = pv;
                        B = qv;
                        break;

                    // Just in case we overshoot on our math by a little, we put these here. Since its a switch it won't slow us down at all to put these here.

                    case 6:
                        R = V;
                        G = tv;
                        B = pv;
                        break;
                    case -1:
                        R = V;
                        G = pv;
                        B = qv;
                        break;

                    // The color is not defined, we should throw an error.

                    default:
                        //LFATAL("i Value error in Pixel conversion, Value is %d", i);
                        R = G = B = V; // Just pretend its black/white
                        break;
                }
            }
            r = Clamp((int)(R * 255.0));
            g = Clamp((int)(G * 255.0));
            b = Clamp((int)(B * 255.0));
        }

        /// <summary>
        /// Clamp a value to 0-255
        /// </summary>
        int Clamp(int i)
        {
            if (i < 0) return 0;
            if (i > 255) return 255;
            return i;
        }
    }
}
