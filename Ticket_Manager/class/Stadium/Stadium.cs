using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Manager
{
    public class Stadium : IStadium
    {
        private string name;
        private string town { get; set; }
        private int capacity { get; set; }

        private List<string> stands;


        public Stadium(string name, string town, int capacity)
        {
            stands = new List<string>();
            this.name = name; this.town = town; this.capacity = capacity;
        }
        public string Name { get { return name; } }
        public string Town { get { return town; } }
        public int Capacity { get { return capacity; } }

        public Stadium AddStand(string stand)
        {
            stands.Add(stand);
            return this;
        }

    }
}
