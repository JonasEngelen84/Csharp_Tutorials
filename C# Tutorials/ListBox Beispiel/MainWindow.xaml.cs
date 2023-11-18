using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ListBox_Beispiel
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Match> matches = new List<Match>
            {
                new Match() { Team1 = "Borussia Dortmund", Team2 = "Bayern München", Score1 = "4", Score2 = "0", Completion = 55 },
                new Match() { Team1 = "1. FC Köln", Team2 = "TSG 1899 Hoffenheim", Score1 = "3", Score2 = "2", Completion = 70 },
                new Match() { Team1 = "Werder Bremen", Team2 = "Union Berlin", Score1 = "1", Score2 = "3", Completion = 60 },
                new Match() { Team1 = "Schalke 04", Team2 = "Hertha BSC", Score1 = "0", Score2 = "3", Completion = 65 },
                new Match() { Team1 = "SC Freiburg", Team2 = "VFL Wolfsburg", Score1 = "1", Score2 = "1", Completion = 59 },
                new Match() { Team1 = "Borussia Mönchengladbach", Team2 = "RB Leipzig", Score1 = "2", Score2 = "1", Completion = 63 }
            };

            LbMatches.ItemsSource = matches;
        }

        private void ButtonDetails(object sender, RoutedEventArgs e)
        {
            if (LbMatches.SelectedItem != null)
            {
                MessageBox.Show($"Im Spiel {(LbMatches.SelectedItem as Match).Team1}"
                + $" gegen {(LbMatches.SelectedItem as Match).Team2} steht es in der"
                + $" {(LbMatches.SelectedItem as Match).Completion}. Min"
                + $" {(LbMatches.SelectedItem as Match).Score1} :"
                + $" {(LbMatches.SelectedItem as Match).Score2}");
            }
        }
    }
}
