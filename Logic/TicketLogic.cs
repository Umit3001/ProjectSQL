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
        int lastAssignedServiceDeskEmployeeIndex;
        public TicketLogic()
        {
            ticketDao = new TicketDao();
            lastAssignedServiceDeskEmployeeIndex = -1;
        }
        public List<Ticket> GetAllTickets()
        {
            return ticketDao.GetAllTickets();
        }

        public void InsertTicket(Ticket ticket)
        {
            ticketDao.InsertTicket(ticket);
        }

        public int GetNextServiceDeskEmployeeIndex(List<string> serviceDeskEmployeeIds)
        {
            if (serviceDeskEmployeeIds.Count == 0)
            {
                return -1;
            }

            lastAssignedServiceDeskEmployeeIndex++;

            if (lastAssignedServiceDeskEmployeeIndex >= serviceDeskEmployeeIds.Count)
            {
                lastAssignedServiceDeskEmployeeIndex = 0;
            }

            return lastAssignedServiceDeskEmployeeIndex;
        }
    }
}
