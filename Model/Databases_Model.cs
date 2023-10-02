using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Databases_Model
    {
        [BsonElement("name")]
        public string name { get; set; }

        [BsonElement("sizeOnDisk")]
        public double size { get; set; }

        [BsonElement("empty")]
        public bool empty { get; set; }
    }
}
