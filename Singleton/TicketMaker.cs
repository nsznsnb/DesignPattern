using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class TicketMaker
    {
        private int ticket = 1000;
        private readonly object lockObject = new object();

        private static TicketMaker _ticketMaker = new();

        private TicketMaker() { }
        public static TicketMaker GetInstance()
        {
            return _ticketMaker; 
        }

        public int GetNextTicketNumber()
        {
            lock (lockObject)
            {
                return ticket++;

            }
        }
    }
}
