using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;

namespace WpfDrawing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Point currentPoint = new Point();
        
        

        bool draw = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Canvas_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
                currentPoint = e.GetPosition(this);

            draw = true;
        }

        private void Canvas_MouseUp_1(object sender, MouseButtonEventArgs e)
        {
            draw = false;
        }

        private void Canvas_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (draw == true)
            {

                if (rbtnColorBlack.IsChecked == true && rbtnSizeSmall.IsChecked == true)
                {
                    Line line = new Line();
                    SolidColorBrush brush = new SolidColorBrush();
                    brush.Color = Colors.Black;
                    line.StrokeThickness = 1;
                    line.Stroke = brush;
                    line.X1 = currentPoint.X;
                    line.Y1 = currentPoint.Y;
                    line.X2 = e.GetPosition(this).X;
                    line.Y2 = e.GetPosition(this).Y;

                    currentPoint = e.GetPosition(this);

                    Canvas.Children.Add(line);
                }

                if (rbtnColorBlue.IsChecked == true && rbtnSizeSmall.IsChecked == true)
                {
                    Line line = new Line();
                    SolidColorBrush brush = new SolidColorBrush();
                    brush.Color = Colors.Blue;
                    line.StrokeThickness = 1;
                    line.Stroke = brush;
                    line.X1 = currentPoint.X;
                    line.Y1 = currentPoint.Y;
                    line.X2 = e.GetPosition(this).X;
                    line.Y2 = e.GetPosition(this).Y;

                    currentPoint = e.GetPosition(this);

                    Canvas.Children.Add(line);
                }

                if (rbtnColorRed.IsChecked == true && rbtnSizeSmall.IsChecked == true)
                {
                    Line line = new Line();
                    SolidColorBrush brush = new SolidColorBrush();
                    brush.Color = Colors.Red;
                    line.StrokeThickness = 1;
                    line.Stroke = brush;
                    line.X1 = currentPoint.X;
                    line.Y1 = currentPoint.Y;
                    line.X2 = e.GetPosition(this).X;
                    line.Y2 = e.GetPosition(this).Y;

                    currentPoint = e.GetPosition(this);

                    Canvas.Children.Add(line);
                }

                if (rbtnColorBlack.IsChecked == true && rbtnSizeMedium.IsChecked == true)
                {
                    Line line = new Line();
                    SolidColorBrush brush = new SolidColorBrush();
                    brush.Color = Colors.Black;
                    line.StrokeThickness = 5;
                    line.Stroke = brush;
                    line.X1 = currentPoint.X;
                    line.Y1 = currentPoint.Y;
                    line.X2 = e.GetPosition(this).X;
                    line.Y2 = e.GetPosition(this).Y;

                    currentPoint = e.GetPosition(this);

                    Canvas.Children.Add(line);
                }

                if (rbtnColorBlue.IsChecked == true && rbtnSizeMedium.IsChecked == true)
                {
                    Line line = new Line();
                    SolidColorBrush brush = new SolidColorBrush();
                    brush.Color = Colors.Blue;
                    line.StrokeThickness = 5;
                    line.Stroke = brush;
                    line.X1 = currentPoint.X;
                    line.Y1 = currentPoint.Y;
                    line.X2 = e.GetPosition(this).X;
                    line.Y2 = e.GetPosition(this).Y;

                    currentPoint = e.GetPosition(this);

                    Canvas.Children.Add(line);
                }

                if (rbtnColorRed.IsChecked == true && rbtnSizeMedium.IsChecked == true)
                {
                    Line line = new Line();
                    SolidColorBrush brush = new SolidColorBrush();
                    brush.Color = Colors.Red;
                    line.StrokeThickness = 5;
                    line.Stroke = brush;
                    line.X1 = currentPoint.X;
                    line.Y1 = currentPoint.Y;
                    line.X2 = e.GetPosition(this).X;
                    line.Y2 = e.GetPosition(this).Y;

                    currentPoint = e.GetPosition(this);

                    Canvas.Children.Add(line);
                }

                if (rbtnColorBlack.IsChecked == true && rbtnSizeLarge.IsChecked == true)
                {
                    Line line = new Line();
                    SolidColorBrush brush = new SolidColorBrush();
                    brush.Color = Colors.Black;
                    line.StrokeThickness = 9;
                    line.Stroke = brush;
                    line.X1 = currentPoint.X;
                    line.Y1 = currentPoint.Y;
                    line.X2 = e.GetPosition(this).X;
                    line.Y2 = e.GetPosition(this).Y;

                    currentPoint = e.GetPosition(this);

                    Canvas.Children.Add(line);
                }

                if (rbtnColorBlue.IsChecked == true && rbtnSizeLarge.IsChecked == true)
                {
                    Line line = new Line();
                    SolidColorBrush brush = new SolidColorBrush();
                    brush.Color = Colors.Blue;
                    line.StrokeThickness = 9;
                    line.Stroke = brush;
                    line.X1 = currentPoint.X;
                    line.Y1 = currentPoint.Y;
                    line.X2 = e.GetPosition(this).X;
                    line.Y2 = e.GetPosition(this).Y;

                    currentPoint = e.GetPosition(this);

                    Canvas.Children.Add(line);
                }

                if (rbtnColorRed.IsChecked == true && rbtnSizeLarge.IsChecked == true)
                {
                    Line line = new Line();
                    SolidColorBrush brush = new SolidColorBrush();
                    brush.Color = Colors.Red;
                    line.StrokeThickness = 9;
                    line.Stroke = brush;
                    line.X1 = currentPoint.X;
                    line.Y1 = currentPoint.Y;
                    line.X2 = e.GetPosition(this).X;
                    line.Y2 = e.GetPosition(this).Y;

                    currentPoint = e.GetPosition(this);

                    Canvas.Children.Add(line);
                }
            }
        }
    }
}
