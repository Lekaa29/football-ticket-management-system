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

namespace Ticket_Manager
{
    /// <summary>
    /// Interaction logic for ItemDetailsPage.xaml
    /// </summary>
    public partial class ItemDetailsPage : Page
    {
        public ItemDetailsPage(Match match)
        {
            InitializeComponent();
            MatchNameTextBlock.Text = $"{ match.TeamHome } - { match.TeamAway }";
            //MatchDateTextBlock.Text = match.Date.ToString();
            //MatchLocationTextBlock.Text = match;
        }   



    }
}
