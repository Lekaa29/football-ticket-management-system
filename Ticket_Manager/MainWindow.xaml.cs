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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        private AuctionManager auctionManager;
        public MainWindow()
        {
            InitializeComponent();

            this.auctionManager = new AuctionManager();



            MainFrame.Navigate(new MainPage());

        }

        private void AdminButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(AdminPage.Instance);
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MainPage());
        }

        private void TicketButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MyTicketPage());
        }

        private void VerifierButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new VerifierPage());

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }


    }
}
