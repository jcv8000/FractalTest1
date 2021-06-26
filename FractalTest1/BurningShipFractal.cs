using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractalTest1
{
    class BurningShipFractal : Fractal
    {

        Bitmap img;

        public BurningShipFractal(int width, int height)
        {
            WIDTH = width;
            HEIGHT = height;

            img = new Bitmap(WIDTH, HEIGHT);

            defaultLowerX = -3.0;
            defaultLowerY = -3.0;
            defaultUpperX = 3.0;
            defaultUpperY = 3.0;

            lowerX = defaultLowerX;
            lowerY = defaultLowerY;
            upperX = defaultUpperX;
            upperY = defaultUpperY;
        }

        public override Image Render()
        {
            const int ITERATIONS = 100;
            const double BREAKPOINT = 2.0;

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

            return img;
        }
    }
}
