using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace DrawingApp
{
    public partial class MainWindow : Window
    {
        private bool isDrawing = false;
        private Polyline currentLine;
        private int lineThickness;
        private Brush selectedColor = Brushes.Black;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MyCanvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            isDrawing = true;
            currentLine = new Polyline
            {
                Stroke = selectedColor,
                StrokeThickness = lineThickness
            };
            MyCanvas.Children.Add(currentLine);
        }

        private void MyCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing && currentLine != null)
            {
                currentLine.Points.Add(e.GetPosition(MyCanvas));
            }
        }

        private void MyCanvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            isDrawing = false;
            currentLine = null;
        }

        private void ThicknessValueSlider(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (sender is Slider slider)
            {
                lineThickness = Convert.ToInt32(slider.Value);
            }
        }

        private void ClearCanvas(object sender, RoutedEventArgs e)
        {
            MyCanvas.Children.Clear();
            lineThickness = 2;
            selectedColor = Brushes.Black;
            LineWidthSlider.Value = 2;
            ColorPicker.SelectedIndex = 0;
        }
        private void ColorPicker_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ColorPicker.SelectedItem is ComboBoxItem selectedItem)
            {
                string colorName = selectedItem.Tag.ToString();
                //selectedColor = (Brush)new BrushConverter().ConvertFromString(colorName);
                switch (colorName)
                {
                    case "black":
                        selectedColor = Brushes.Black;
                        break;
                    case "blue":
                        selectedColor = Brushes.Blue;
                        break;
                    case "green":
                        selectedColor = Brushes.Green;
                        break;
                    case "red":
                        selectedColor = Brushes.Red;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
