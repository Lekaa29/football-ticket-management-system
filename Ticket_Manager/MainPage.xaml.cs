using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Ticket_Manager
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        private ObservableCollection<Auction> Auctions { get; set; }

        public MainPage()
        {
            InitializeComponent();

            

          
            MatchesListBox.ItemsSource = Auctions;
        }


        private void MatchesListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (MatchesListBox.SelectedItem is Match selectedMatch)
            {
                NavigationService.Navigate(new ItemDetailsPage(selectedMatch));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void SearchBox_GotFocus(object sender, RoutedEventArgs e)
        {

            TextBox textBox = sender as TextBox;
            if (textBox.Foreground == Brushes.Gray)
            {
                textBox.Text = "";
                textBox.Foreground = Brushes.Black;
            }
        }

        private void SearchBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (textBox.Name == "SearchTextBox")
                {
                    textBox.Text = "Search";
                }
                else if (textBox.Name == "MinTextBox")
                {
                    textBox.Text = "Min";
                }
                else if (textBox.Name == "MaxTextBox")
                {
                    textBox.Text = "Max";
                }
                textBox.Foreground = Brushes.Gray;
            }
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

    }
}
