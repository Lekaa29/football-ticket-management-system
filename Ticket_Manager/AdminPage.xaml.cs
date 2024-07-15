using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        private static AdminPage _instance;

        private TeamManager teamManager;
        private TicketManager ticketManager;
        private AuctionManager auctionManager;

        public static AdminPage Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AdminPage();
                }

              


                return _instance;
            }
        }   

        public AdminPage()
        {
            InitializeComponent();
            teamManager = new TeamManager();
            ticketManager = new TicketManager();
            auctionManager = new AuctionManager();
        }

        public TeamManager TeamManager { get { return teamManager; } }
        public TicketManager TicketManager { get { return ticketManager; } }
        public AuctionManager AuctionManager { get { return auctionManager; } }


        private void AddTeam_Click(object sender, RoutedEventArgs e)
        {
            string teamName = TeamName.Text;
            string teamLogo = TeamLogo.Text;
            string venue = Stadium.Text;
            string town = Town.Text;
            int capacity = int.Parse(Capacity.Text);

            

            teamManager.AddTeam(new Team(teamName, teamLogo, venue, town, capacity));

            List<Team> teams = teamManager.GetTeams();
            SearchableAwayTeamComboBox.ItemsSource = teams;
            SearchableHomeTeamComboBox.ItemsSource = teams;
            
            teamOutput.Content = $"{ teamName } added";
            

        }

       

        private void AddMatch_Click(object sender, RoutedEventArgs e)
        {
           
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
