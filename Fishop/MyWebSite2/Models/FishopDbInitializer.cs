using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyWebSite2.Models
{
    public class FishopDbInitializer : DropCreateDatabaseAlways<FishopDbContext>
    {
        protected override void Seed(FishopDbContext db)
        {
            db.Rods.Add(new Rod(1, 1, "Удка", "Задний"));
            db.Rods.Add(new Rod(2, 1, "Удейка", "Средний"));
            db.Rods.Add(new Rod(31, 1, "Удавка", "передний"));
            base.Seed(db);
        }
    }
}

    