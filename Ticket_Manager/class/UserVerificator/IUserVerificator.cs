using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Manager
{
    internal interface IUserVerificator
    {
        bool IsEligible(User user);
    }
}
