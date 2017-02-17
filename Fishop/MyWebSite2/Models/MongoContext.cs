using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.GridFS;
using MongoDB.Driver.Linq;


namespace MyWebSite2.Models
{
    public class MongoContext
    {
        private static string connectionString = "mongodb://localhost:27017";
        public IMongoDatabase database { get; set; }

        public MongoContext() {
        MongoClient client = new MongoClient(connectionString);
        database = client.GetDatabase("test");
            

}
        
    }
}