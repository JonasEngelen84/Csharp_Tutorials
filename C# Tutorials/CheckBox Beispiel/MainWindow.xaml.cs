using System.Windows;

namespace CheckBox_Beispiel
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

        private void cBAlleBelägeChecked(object sender, RoutedEventArgs e)
        {
            bool newVal = (cBAlleBeläge.IsChecked == true);
            cBSalami.IsChecked = newVal;
            cBGouda.IsChecked = newVal;
            cBChampignons.IsChecked = newVal;
        }

        private void cBEinzelbelag(object sender, RoutedEventArgs e)
        {
            cBAlleBeläge.IsChecked = null;
            if ((cBSalami.IsChecked == true) && (cBChampignons.IsChecked == true) && (cBGouda.IsChecked == true))
            {
                _ = cBAlleBeläge.IsChecked == true;
            }
            if ((cBSalami.IsChecked == false) || (cBChampignons.IsChecked == false) || (cBGouda.IsChecked == false))
            {
                _ = cBAlleBeläge.IsChecked == false;
            }
        }
    }
}
