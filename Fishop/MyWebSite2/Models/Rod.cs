using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebSite2.Models
{
    public class Rod : Product
    {
        public Rod() { }

        public Rod(int Id, int Categoryid, string Name, string Construction) : base(Id, Categoryid, Name) {

            this.Construction = Construction;
        }
        public string Construction { get; set; }
         public int SectionsNumber { get; set; }
    }
}