using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Manager
{
    internal class User
    {
        private string username;
        private string password;
        private string name;
        private string surname;
        private string email;
        private string phone;
        private int id = -1;

        private UserManager userManager;

        public User(string username, string password, string name, string surname, string email, string phone)
        {
            this.username = username; 
            this.password = password;
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.phone = phone;
        }
        
        public string Password {  get { return password; } }
        public string Email { get { return email; } }
        public int Id { get { return id; } }
        public void SetId(int id)
        {
            this.id = id;
        }

    }
}
