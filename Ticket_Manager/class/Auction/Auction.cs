using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Manager
{
    public class Auction
    {
        
        private Match match;
        private int price;
        private string stand;
        private List<string> seats;
        

        public Auction( Match match, string stand, List<string> seats, int price)
        {
            this.seats = seats;
            this.match = match;
            this.price = price;
            this.stand = stand;
        }

        public int GetAvailable() { return  seats.Count; }
        public int Price {  get { return price; } }
        public Match Match { get { return this.match; } }
        public string Stand { get { return this.stand; } }
        public string GetSeat () 
        {
            string seat = seats[0];
            seats.RemoveAt(0);
            return seat;
        }

        public void AddSeat(string seat)
        {
            seats.Add(seat);
        }

    }
}
