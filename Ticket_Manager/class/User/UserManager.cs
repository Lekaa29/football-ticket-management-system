using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Manager
{
    internal class UserManager
    {
        private static int userCounter;

        private static UserManager instance;

        private IUserVerificator userVerificator;

        private Dictionary<int, User> users;

        private UserManager(IUserVerificator userVerificator) 
        {
            this.userVerificator = userVerificator;
            userCounter = 0;
            this.users = new Dictionary<int, User>();
        }

        public static UserManager GetInstance(IUserVerificator userVerificator)
        {
            if(instance == null)
            {
                instance = new UserManager(userVerificator);
            }
            return instance;
        }

        public void SetUserVerificator(IUserVerificator userVerificator)
        {
            this.userVerificator = userVerificator;
        }

        public void AddUser(User newUser)
        {
            if (this.userVerificator.IsEligible(newUser))
            {
                users.Add(userCounter,newUser);
                newUser.SetId(userCounter);
                userCounter++;
            }
        }

        public bool IsAdded(User user)
        {
            return user.Id != -1 && users.Keys.Contains(user.Id);
        }
        
    }
}
