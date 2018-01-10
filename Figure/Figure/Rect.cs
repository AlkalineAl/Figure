using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace Figure
{
    class Rect : Square
    {
        public Rect(int height, int width, Color color) : base(height, color)
        {
            rectangle.Width = width;
        }
    }
}
