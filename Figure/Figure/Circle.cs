
using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

namespace Figure
{
    public class Circle : BaseFigure
    {
        public  Ellipse ellipse = new Ellipse();

        public Circle(int height,Color color) : base(height, color)
        {
            ellipse.Fill = new SolidColorBrush(color);
            ellipse.Width = height;
            ellipse.Height = height;

        }

        public override void Draw()
        {
            MainPage.rootGrid.Children.Add(ellipse);

        }
    }
}
