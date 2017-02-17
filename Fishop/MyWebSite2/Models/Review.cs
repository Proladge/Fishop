using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebSite2.Models
{
    public class Review
    {
        public int ID { get; set; }
        public int parentReview { get; set; }
        public string Name { get; set; }
        public string reviewText { get; set; }
        public string Phone { get; set; }
        public DateTime Date { get; set; }

    }
}