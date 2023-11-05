using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class TicketLogic
    {
        private TicketDao ticketDao;
        public TicketLogic()
        {
            ticketDao = new TicketDao();
        }
        public List<Ticket> GetAllTickets()
        {
            return ticketDao.GetAllTickets();
        }

        public void InsertTicket(Ticket ticket)
        {
            ticketDao.InsertTicket(ticket);
        }
    }
}
