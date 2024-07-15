using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Manager
{
    public class AuctionManager
    {
        private List<Auction> auctions;
        
        public AuctionManager()
        {
            this.auctions = new List<Auction>();
        }

        public void AddAuction(Auction auction)
        {
            this.auctions.Add(auction);
        }

        public void RemoveAuction(Auction auction)
        {
            this.auctions.Remove(auction);
        }

       
    }
}
