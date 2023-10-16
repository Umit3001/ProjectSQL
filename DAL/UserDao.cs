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
    public class UserDao : BaseDao
    {
        public UserDao() : base("User")
        {
        }

        public User FindUser(string username, string password)
        {
            // Voer een query uit om de gebruiker te vinden op basis van gebruikersnaam en wachtwoord.
            var filter = Builders<BsonDocument>.Filter.Eq("Username", username) & Builders<BsonDocument>.Filter.Eq("Password", password);
            var userDocument = Collection.Find(filter).FirstOrDefault();

            if (userDocument != null)
            {
                // Map het gevonden document naar een User-object.
                User foundUser = BsonSerializer.Deserialize<User>(userDocument);

                return foundUser;
            }

            return null; // User not found
        }

        

    }
}
