using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace Figure
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public static Grid rootGrid = new Grid();
        
        public MainPage()
        {
            
            this.InitializeComponent();
            rootGrid.Height = 700;
            rootGrid.Width = 700;




            

        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            figureGrid.Children.Clear();
            rootGrid.Children.Clear();
            Circle circle = new Circle(25, Windows.UI.Colors.Blue);
            circle.Draw();
            figureGrid.Children.Add(rootGrid);
        }

        private void AppBarButton_Click_1(object sender, RoutedEventArgs e)
        {
            figureGrid.Children.Clear();
            rootGrid.Children.Clear();
            Oval oval = new Oval(40, 30, Windows.UI.Colors.Coral);
            oval.Draw();
            figureGrid.Children.Add(rootGrid);
        }

        private void AppBarButton_Click_2(object sender, RoutedEventArgs e)
        {
            figureGrid.Children.Clear();
            rootGrid.Children.Clear();
            Square square = new Square(88, Windows.UI.Colors.DarkMagenta);
            square.Draw();
            figureGrid.Children.Add(rootGrid);
        }

        private void AppBarButton_Click_3(object sender, RoutedEventArgs e)
        {
            figureGrid.Children.Clear();
            rootGrid.Children.Clear();
            Rect rectangle = new Rect(45, 99, Windows.UI.Colors.DeepPink);
            rectangle.Draw();
            figureGrid.Children.Add(rootGrid);
        }
    }
}
