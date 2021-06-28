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

        DirectBitmap img;

        public BurningShipFractal(int width, int height)
        {
            WIDTH = width;
            HEIGHT = height;

            flippedY = true;

            img = new DirectBitmap(WIDTH, HEIGHT);

            defaultLowerX = -3;
            defaultLowerY = -3;
            defaultUpperX = 3;
            defaultUpperY = 3;

            lowerX = defaultLowerX;
            lowerY = defaultLowerY;
            upperX = defaultUpperX;
            upperY = defaultUpperY;
        }

        public override Image Render()
        {
            const int ITERATIONS = 100;
            const double BREAKPOINT = 2.0;

            Color[,] pixels = new Color[WIDTH, HEIGHT];

            Parallel.For(0, WIDTH, px =>
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
                        int brightness = 255 - (int)(((double)i / ITERATIONS) * 255);
                        color = Color.FromArgb(brightness, brightness, brightness);
                    }

                    pixels[px, py] = color;
                }
            });

            for (int x = 0; x < WIDTH; x++)
            {
                for (int y = 0; y < HEIGHT; y++)
                {
                    img.SetPixel(x, y, pixels[x, y]);
                }
            }

            return img.Bitmap;
        }

        // x - a number, from which we need to calculate the square root
        // epsilon - an accuracy of calculation of the root from our number.
        // The result of the calculations will differ from an actual value
        // of the root on less than epslion.
        public decimal Sqrt(decimal x, decimal epsilon = 0.0M)
        {
            if (x < 0) throw new OverflowException("Cannot calculate square root from a negative number");

            decimal current = (decimal)Math.Sqrt((double)x), previous;
            do
            {
                previous = current;
                if (previous == 0.0M) return 0;
                current = (previous + x / previous) / 2;
            }
            while (Math.Abs(previous - current) > epsilon);
            return current;
        }
    }
}
