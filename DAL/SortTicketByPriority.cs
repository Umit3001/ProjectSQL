using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SortTicketByPriority
    {
        public List<Ticket> SortByPriority(List<Ticket> tickets)
        {
            var sortedTickets = tickets.OrderBy(ticket => ticket.Priority).ToList();

            return sortedTickets;
        }
    }
}
