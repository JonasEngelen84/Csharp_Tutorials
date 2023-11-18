using System.Windows;

namespace Data_Binding
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // setzt den Wert für OneTime
            MySlider.Value = 66;
            MyTextBox.Text = MySlider.Value.ToString();
        }
    }
}
