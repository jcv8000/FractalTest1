using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractalTest1
{
    public abstract class Fractal
    {
        public int WIDTH, HEIGHT;

        public bool flippedY = false;

        protected double defaultLowerX, defaultUpperX, defaultLowerY, defaultUpperY;

        public double lowerX, upperX, lowerY, upperY;

        public abstract Image Render();
    }
}
