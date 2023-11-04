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

        [BsonElement("DateOpened")]
        public string DateTime { get; set; }

        [BsonElement("SubjectOfIncident")]
        public string SubjectOfIncident { get; set; }

        [BsonElement("TypeOfIncident")]
        public TypeOfIncident TypeOfIncident { get; set; }

        [BsonElement("ReportedByUser")]
        public string ReportedByUser { get; set; }
        
        [BsonElement("Priority")]
        public Priority Priority { get; set; }

        [BsonElement("Deadline")]
        public string Deadline { get; set; }

        [BsonElement("Description")]
        public string Description { get; set; }

        [BsonElement("Status")]
        public StatusTicket Status { get; set; }

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

    public enum TypeOfIncident
    {
        ServiceInterruption,
        ServiceDegradation,
        Hardware,
        Software,
        Security,
        Network,
        UserRelated,
        ChangeRelated
    }

    public enum Priority
    {
        High,
        Normal,
        Low
    }


    public class EmployeeReference
    {
        [BsonElement("$_id")]
        public string EmployeeId { get; set; }
    }

}
