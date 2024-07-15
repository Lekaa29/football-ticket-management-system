using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Manager
{
    public class Team
    {
        private string name;
        private string logo;
        private Stadium stadium;

        public Team(string name, string logo, string stadiumName, string town, int capacity)
        {
            this.name = name;
            this.logo = logo;
            this.stadium = new Stadium(stadiumName, town, capacity);
        }

        public string Name { get { return name; } }
        public string Logo { get { return logo; } }
        public Stadium Stadium { get { return stadium; } }

        public override string ToString()
        {
            return name;

        }
    }

}
