using System.Windows;
using System.Windows.Media;

namespace ComboBoxBeispiel
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            comboBoxColors.ItemsSource = typeof(Colors).GetProperties();
        }
    }
}
