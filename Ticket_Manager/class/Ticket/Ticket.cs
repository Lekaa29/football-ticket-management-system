using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Manager
{
    internal class Ticket
    {
        private TicketManager ticketManager;
        private Auction auction;
        private string code;
        private User owner;
        private string name;
        private string surname;

        private string seat;
        
        public Ticket(Auction auction, User owner, string name, string surname, TicketManager ticketManager)
        {
            this.seat = auction.GetSeat();

            this.ticketManager = ticketManager;

            this.code = this.ticketManager.GenerateCode();

            this.auction = auction;
            this.owner = owner;
            this.name = name;   
            this.surname = surname;
        }
        public string Code {  get { return code; } }
        public void Refund()
        {
            this.ticketManager.RemoveCode(this.code);
            auction.AddSeat(this.seat);
        }

        public string GetOwnerEmail()
        {
            return this.owner.Email;
        }

        public override string ToString()
        {
            string ticket = string.Empty;
            /*
            ticket = $"{auction.Match.Competition.Name}\n" +
                $"{auction.Match.TeamHome} - {auction.Match.TeamAway}\n" +
                $"{auction.Stadium.Name}, {auction.Stadium.Town}, Capacity:{auction.Stadium.Capacity}\n" +
                $"DATE: {auction.Match.Date}" +
                $"\nTICKET\nNAME: {this.name} {this.surname}\n" +
                $"SEAT: {this.seat}\n" +
                $"STAND: {auction.Stand}" +
                $"\n {auction.Price} $ \n" +
                $"\n\nCODE: {this.code}";
            */
            return ticket;
        }
    }
}
