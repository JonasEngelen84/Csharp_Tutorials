using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Buttons
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Grid eigenesGrid = new Grid();
            eigenesGrid.Height = 250;
            eigenesGrid.VerticalAlignment = VerticalAlignment.Bottom;

            // Grid an MainWindow übergeben:
            // (Überschreibt das Grid aus der Xaml!)
            this.Content = eigenesGrid;

            Button btn = new Button();
            btn.FontSize = 30;
            btn.Width = 250;
            btn.Height = 100;
            btn.VerticalAlignment = VerticalAlignment.Bottom;

            WrapPanel wp = new WrapPanel();

            TextBlock txt = new TextBlock
            {
                Text = "Multi",
                Foreground = Brushes.Blue
            };
            wp.Children.Add(txt);

            txt = new TextBlock
            {
                Text = "Color",
                Foreground = Brushes.Red
            };
            wp.Children.Add(txt);

            txt = new TextBlock
            {
                Text = "Button",
                Foreground = Brushes.Green
            };
            wp.Children.Add(txt);


            btn.Content = wp;
            eigenesGrid.Children.Add(btn);
        }
    }
}
