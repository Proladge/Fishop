using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyWebSite2.Models
{
    public class FishopDbContext :  DbContext
    {
        public DbSet<Rod> Rods { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Reel> Reels { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}