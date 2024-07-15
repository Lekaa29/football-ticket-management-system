using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Manager
{
    public class TicketManager
    {
        private List<string> usedCodes;
        private List<string> invalidCodes;
        private Random random;
        public TicketManager() 
        {
            this.random = new Random();
            usedCodes = new List<string>();
            invalidCodes = new List<string>();
        }
        public string GenerateCode()
        {

            int code = random.Next(10000000, 99999999 + 1);
            while (usedCodes.Contains(code.ToString()))
            {
                code = random.Next(10000000, 99999999 + 1);
            }

            usedCodes.Add(code.ToString());

            return code.ToString();
        }
        public void RemoveCode(string code)
        {
            invalidCodes.Add(code);
        }
        public bool IsValid(string code)
        {
            return usedCodes.Contains(code) && !(invalidCodes.Contains(code));
        }
    }
}
