using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

namespace Figure
{
    public class Square : BaseFigure
    {
        
        public Rectangle rectangle = new Rectangle();

        public Square(int height, Color color) : base(height, color)
        {
            
            rectangle.Fill = new SolidColorBrush(color);
            rectangle.Width = height;
            rectangle.Height = height;


        }

        public override void Draw()
        {

            MainPage.rootGrid.Children.Add(rectangle);


        }
    }
}
