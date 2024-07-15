using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Manager
{
    internal class StandardVerificator : IUserVerificator
    {
        public StandardVerificator() { }
        public bool IsEligible(User user)
        {
            return IsPasswordSecure(user.Password) && IsEmailCorrect(user.Email);
        }

        private bool IsPasswordSecure(string password)
        {
            return password.Length > 7;
        }

        private bool IsEmailCorrect(string email)
        {
            return email.Contains("@");
        }


    }
}
