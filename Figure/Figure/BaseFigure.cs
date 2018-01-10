
using Windows.UI;

namespace Figure
{
    public abstract class BaseFigure
    {

        public int Height { get; set; }
        public Color Color { get; }

        public BaseFigure(int height, Color color)
        {
            Height = height;
            Color = color;
        }

        public virtual void Draw()
        {

        }
    }
}
