using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Manager
{
    internal class MatchManager
    {
        

        private Dictionary<Auction, Match> matches;

        public MatchManager()
        {
            matches = new Dictionary<Auction, Match>();
        }

        public void AddAuction(Auction auction)
        {
            matches[auction] = auction.Match;
        }

        public void RemoveAuction(Auction auction)
        {
            matches.Remove(auction);
        }

        public List<Auction> GetAllAuctions(Match match)
        {
            var allAuctions = this.matches
                      .Where(a => a.Value == match)
                      .Select(a => a.Key)           
                      .ToList();
            return allAuctions;

        }

        public List<Auction> GetAuctionsInsidePriceRange(int lower, int upper)
        {
            var allAuctions = this.matches
                    .Where(a => a.Key.Price >= lower && a.Key.Price <= upper)
                    .Select(a => a.Key)
                    .ToList();  
            return allAuctions;
        }

        public List<Auction> GetAuctionsSearchPrompt(string search)
        {
            var allAuctions = this.matches
                    .Where(a => a.Key.Match.Competition.Name.ToLower().Contains(search.ToLower())
                    || a.Key.Match.TeamHome.Name.ToLower().Contains(search.ToLower())
                    || a.Key.Match.TeamAway.Name.ToLower().Contains(search.ToLower())
                    || a.Key.Match.TeamHome.Stadium.Town.ToLower().Contains(search.ToLower())
                    || a.Key.Match.TeamHome.Stadium.Name.ToLower().Contains(search.ToLower()))
                    .Select(a => a.Key)
                    .ToList();
            
            return (allAuctions);
        }

        public List<Auction> GetAuctionInsideDateRange(DateTime first, DateTime second)
        {
            var allAuctions = this.matches
                .Where(a => a.Key.Match.Date >= first
                && a.Key.Match.Date <= second)
                .Select(a => a.Key)
                .ToList();
            return (allAuctions);
        }

        


    }
}
