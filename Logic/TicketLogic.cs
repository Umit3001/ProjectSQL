using DAL;
using Model;
using MongoDB.Bson;
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
        private SortTicketByPriority SortTicketByPriority;
        int lastAssignedServiceDeskEmployeeIndex;
        public TicketLogic()
        {
            ticketDao = new TicketDao();
            lastAssignedServiceDeskEmployeeIndex = -1;
            SortTicketByPriority = new SortTicketByPriority();
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

        public List<Ticket> SortByPriority(List<Ticket> tickets)
        {
            return SortTicketByPriority.SortByPriority(tickets);
        }

        public Ticket GetTicketById(string ticketId)
        {
            return ticketDao.GetTicketById(ticketId);
        }

        public void DeleteTicket(Ticket ticket)
        {
            if (ticket != null && ticket.Id != ObjectId.Empty)
            {
                ticketDao.DeleteTicket(ticket);
            }
        }

        public void UpdateTicket(Ticket updatedTicket)
        {
            ticketDao.UpdateTicket(updatedTicket);
        }

        public void CloseTicket(Ticket ticket)
        {
            if (ticket != null)
            {
                ticketDao.CloseTicket(ticket);
            }
        }
    }
}
