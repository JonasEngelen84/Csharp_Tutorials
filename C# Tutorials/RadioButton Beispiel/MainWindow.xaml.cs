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

namespace RadioButton_Beispiel
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void JaButtonChecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Danke, dass du mich magst.");
        }

        private void NeinButtonChecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Dann verpiss dich!!!");
        }

        private void VielleichtButtonChecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Dann lern mich besser kennen ;)");
        }
    }
}
