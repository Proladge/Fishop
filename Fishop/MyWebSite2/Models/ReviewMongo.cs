using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebSite2.Models
{
    public class ReviewMongo
    {

        public MongoDB.Bson.ObjectId _id { get; set; }
        public string Name { get; set; }
        public string ReviewText { get; set; }
        public string Phone { get; set; }
        public DateTime Date { get; set; }
    }
}