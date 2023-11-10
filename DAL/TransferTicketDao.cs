using Model;
using MongoDB.Bson.Serialization;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TransferTicketDao : BaseDao
    {
        public TransferTicketDao() : base("User")
        {
        }

        public User GetUserById(string userId)
        {
            if (ObjectId.TryParse(userId, out ObjectId objectId))
            {
                var filter = Builders<BsonDocument>.Filter.Eq("_id", objectId);
                var userDocument = Collection.Find(filter).FirstOrDefault();

                if (userDocument != null)
                {
                    User foundUser = BsonSerializer.Deserialize<User>(userDocument);
                    return foundUser;
                }
            }

            return null;
        }

        public User GetUserByName(string name)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("Name", name);
            var userDocument = Collection.Find(filter).FirstOrDefault();

            if (userDocument != null)
            {
                User foundUser = BsonSerializer.Deserialize<User>(userDocument);
                return foundUser;
            }

            return null;
        }
    }
}
