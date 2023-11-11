using Model;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Globalization;
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


        public void InsertTicket(Ticket ticket)
        {
            BsonDocument ticketDocument = ticket.ToBsonDocument();
          
            Collection.InsertOne(ticketDocument);
        }

        public Ticket GetTicketById(string ticketId)
        {
            if (ObjectId.TryParse(ticketId, out ObjectId objectId))
            {
                var filter = Builders<BsonDocument>.Filter.Eq("_id", objectId);
                var ticketDocument = Collection.Find(filter).FirstOrDefault();

                if (ticketDocument != null)
                {
                    Ticket foundTicket = BsonSerializer.Deserialize<Ticket>(ticketDocument);
                    return foundTicket;
                }
            }

            return null;
        }

        public void DeleteTicket(Ticket ticket)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ticket.Id);
            Collection.DeleteOne(filter);
        }

        public void UpdateTicket(Ticket updatedTicket)
        {
            if (updatedTicket != null && updatedTicket.Id != ObjectId.Empty)
            {
                var filter = Builders<BsonDocument>.Filter.Eq("_id", updatedTicket.Id);
                BsonDocument ticketDocument = updatedTicket.ToBsonDocument();
                Collection.ReplaceOne(filter, ticketDocument);
            }
        }

        public void CloseTicket(Ticket ticket)
        {
            if (ticket.Status != StatusTicket.Closed.ToString())
            {
                ticket.Status = StatusTicket.Closed.ToString();

                UpdateTicket(ticket);
            }
        }
    }
}
