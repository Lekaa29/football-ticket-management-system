using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Manager
{
    public class TeamManager
    {
        private List<Team> teams;

        public TeamManager()
        {
            this.teams = new List<Team>();
        }

        public void AddTeam(Team team)
        {
            teams.Add(team);
        }

        public void RemoveTeam(Team team)
        {
            teams.Remove(team);
        }

        public List<Team> GetTeams()
        {
            return teams;
        }

 

    }
}
