using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Manager
{
    public class Match
    {
        private Team teamHome;
        private Team teamAway;
        private DateTime? date;
        private Competition competition;
        private Team venue;


        private Dictionary<int, int> prices;

        public Match(Team teamHome, Team teamAway, DateTime? date, Competition competition, Team venue)
        {
            this.teamHome = teamHome;
            this.teamAway = teamAway;
            this.date = date;
            this.competition = competition;
        }
        public Team TeamHome { get {  return teamHome; } }
        public Team TeamAway { get {  return teamAway; } }
        public DateTime? Date { get { return date; } }
        public Competition Competition { get {  return competition; } }
    }
}
