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

        protected IMongoCollection<BsonDocument> Collection;

        public BaseDao(string collectionName)
        {
           
                MongoClient client = new MongoClient("mongodb+srv://TGG:TGGWW@cluster.q8uedss.mongodb.net/");
                var database = client.GetDatabase("TGGDatabase");
                Collection = database.GetCollection<BsonDocument>(collectionName);

        }



    }
}
