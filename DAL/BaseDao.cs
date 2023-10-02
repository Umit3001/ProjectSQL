using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using Model;
using MongoDB.Bson.Serialization;

namespace DAL
{
    public class BaseDao
    {
        private MongoClient client;

        public BaseDao()
        {
            try
            {
                client = new MongoClient("mongodb+srv://697637:Karacauren06@mongodb-cluster.ullii05.mongodb.net/");
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during MongoClient initialization.
                Console.WriteLine("Error initializing MongoClient: " + ex.Message);
            }
        }

        public List<Databases_Model> GetDatabases()
        {
            List<Databases_Model> all_databases = new List<Databases_Model>();

            try
            {
                foreach (BsonDocument db in client.ListDatabases().ToList())
                {
                    all_databases.Add(BsonSerializer.Deserialize<Databases_Model>(db));
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during database operations.
                Console.WriteLine("Error while getting databases: " + ex.Message);
            }

            return all_databases;
        }
        public List<string> GetCollectionNames(string databaseName)
        {
            List<string> collectionNames = new List<string>();
            IAsyncCursor<string> cursor = null;

            try
            {
                var database = client.GetDatabase(databaseName);
                cursor = database.ListCollectionNames();

                foreach (var collectionName in cursor.ToList())
                {
                    collectionNames.Add(collectionName);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while getting collection names: " + ex.Message);
            }
            finally
            {
                if (cursor != null)
                {
                    cursor.Dispose();
                }
            }

            return collectionNames;
        }
        public List<BsonDocument> GetDocuments(string databaseName, string collectionName)
        {
            List<BsonDocument> documents = new List<BsonDocument>();

            try
            {
                var database = client.GetDatabase(databaseName);
                var collection = database.GetCollection<BsonDocument>(collectionName);

                var filter = new BsonDocument(); // You can add a filter if needed

                var cursor = collection.Find(filter).ToListAsync();

                documents = cursor.Result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while getting documents: " + ex.Message);
            }

            return documents;
        }
    }
}
