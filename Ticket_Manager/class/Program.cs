namespace Ticket_Manager
{
    /*
    internal class Program
    {
        static void Main(string[] args)
        {
            Stadium oldTrafford = new Stadium("Old Trafford", "Manchester", 65000);

            oldTrafford.AddStand("low corner").AddStand("vip stand").AddStand("big stand");

            Competition championsLeague = new Competition("UEFA Champions League");

            Match semifinal = new Match("Manchester United", "Real Madrid", DateTime.Now, championsLeague);

            Auction semifinalHome = new Auction(oldTrafford, semifinal, "vip stand", 
                new List<string>(["A1", "A2", "A3"]), 300);


            User leka = new User("lekaa29", "abcd1234", "Lovro", "Lesic", "lovro@gmail.com", "+385919193492");

            IUserVerificator userStandardVerificator = new StandardVerificator();

            UserManager userManager = UserManager.GetInstance(userStandardVerificator);

            userManager.AddUser(leka);

            TicketManager ticketManager = new TicketManager();

            Ticket boughtTicket = new Ticket(semifinalHome, leka, "Ivan", "Lesic", ticketManager);

            string card = string.Empty;
            card = boughtTicket.ToString();

            Console.WriteLine(card);

            Console.WriteLine(ticketManager.IsValid(boughtTicket.Code));
            boughtTicket.Refund();
            Console.WriteLine(ticketManager.IsValid(boughtTicket.Code));



        }
    }
    */
}