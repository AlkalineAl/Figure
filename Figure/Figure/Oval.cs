using Windows.UI;


namespace Figure
{
    public class Oval : Circle
    {

        public Oval(int height, int width, Color color) : base(height,  color)
        {

            ellipse.Width = width;
        }

    }
}
