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
        public ObjectId Id { get; set; }

        [BsonElement("DateOpened")]
        public string DateOpened { get; set; }

        [BsonElement("SubjectOfIncident")]
        public string SubjectOfIncident { get; set; }

        [BsonElement("TypeOfIncident")]
        public string TypeOfIncident { get; set; }

        [BsonElement("ReportedByUser")]
        public string ReportedByUser { get; set; }
        
        [BsonElement("Priority")]
        public string Priority { get; set; }

        [BsonElement("Deadline")]
        public string Deadline { get; set; }

        [BsonElement("Description")]
        public string Description { get; set; }

        [BsonElement("Status")]
        public string Status { get; set; }

        [BsonElement("ServiceDeskEmployeeID")]
        public EmployeeReference ServiceDeskEmployeeID { get; set; }

        [BsonElement("RegularEmployeeID")]
        public EmployeeReference RegularEmployeeID { get; set; }


    }

    public enum StatusTicket
    {
        InProgress,
        Handled,
        Closed,
        Pending,
        Reopened
    }


    public class EmployeeReference
    {
        [BsonElement("$_id")]
        public string EmployeeId { get; set; }
    }

}
