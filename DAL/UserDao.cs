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
        List<User> users;

        public UserDao() : base("User")
        {
            users = new List<User>();
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

        public List<User> GetAllUsers()
        {
            var userDocuments = Collection.Find(new BsonDocument()).ToList();
       

            foreach (var userDocument in userDocuments)
            {
                User user = BsonSerializer.Deserialize<User>(userDocument);
                users.Add(user);
            }

            return users;
        }


        public void AddUser(User newUser)
        {
            BsonDocument userDocument = new BsonDocument{
                { "Name", newUser.Name },
                { "Username", newUser.Username },
                { "Password", newUser.Password },
                { "Email", newUser.Email },
                { "PhoneNumber", newUser.PhoneNumber },
                { "Location", newUser.UserLocation.ToString() },
                { "TypeOfEmployee", newUser.EmployeeType.ToString() },
                };

            Collection.InsertOne(userDocument);

        }

        public List<string> GetServiceDeskEmployeeIds()
        {
            var filter = Builders<BsonDocument>.Filter.Eq("TypeOfEmployee", "ServiceDesk");
            var serviceDeskUserDocuments = Collection.Find(filter).ToList();

            List<string> serviceDeskEmployeeIds = new List<string>();

            foreach (var serviceDeskUserDocument in serviceDeskUserDocuments)
            {
                serviceDeskEmployeeIds.Add(serviceDeskUserDocument["_id"].ToString());
            }

            return serviceDeskEmployeeIds;
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

