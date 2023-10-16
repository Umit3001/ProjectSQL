using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Ticket
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Description")]
        public string Description { get; set; }

        [BsonElement("DateOpened")]
        public string DateTime { get; set; }

        [BsonElement("Status")]
        public StatusTicket Status { get; set; }

        [BsonElement("ServiceDeskEmployeeID")]
        [BsonRepresentation(BsonType.ObjectId)] // Assuming ServiceDeskEmployeeID is an ObjectId
        public string ServiceDeskEmployeeID { get; set; }

        [BsonElement("RegularEmployeeID")]
        [BsonRepresentation(BsonType.ObjectId)] // Assuming RegularEmployeeID is an ObjectId
        public string RegularEmployeeID { get; set; }
    }

    public enum StatusTicket
    {
        InProgress,
        Handled,
        Closed,
        Pending,
        Reopened
    }
}
