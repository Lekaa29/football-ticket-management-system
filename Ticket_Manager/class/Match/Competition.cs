using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Manager
{
    public class Competition
    {
        private string name;
        private string logo;
        public Competition(string name) 
        { 
            this.name = name;
            this.logo = logo;
        
        }
        public string Name { get { return name; } }
        public string Logo { get { return logo; } }
    }
}
