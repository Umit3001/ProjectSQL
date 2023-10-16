using Model;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TicketDao : BaseDao
    {
        public TicketDao() : base("Ticket")
        {
        }

        public List<Ticket> GetAllTickets()
        {
            var ticketFilter = new BsonDocument(); 
            var ticketDocuments = Collection.Find(ticketFilter).ToList();

            List<Ticket> tickets = new List<Ticket>();

            foreach (var ticketDocument in ticketDocuments)
            {
                Ticket ticket = BsonSerializer.Deserialize<Ticket>(ticketDocument);
                tickets.Add(ticket);
            }

            return tickets;
        }

    }
}
