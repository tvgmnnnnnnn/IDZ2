using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iz2_opp
{
    internal class Client
    {
        public string fio;
        public string Number;

        public Client(string pFio, string pTicket)
        {
            this.fio = pFio;
            this.Number = pTicket;
        }
    }
}
