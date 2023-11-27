using MongoDB.Bson.Serialization;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class ResetPassword : BaseDao
    {
        public ResetPassword() : base("User")
        {
        }

        public void UpdatePassword(string userId, string newPassword)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(userId));
            var update = Builders<BsonDocument>.Update.Set("Password", newPassword);

            Collection.UpdateOne(filter, update);
        }
        public User GetUserByEmail(string email)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("Email", email);
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
