using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebSite2.Models
{
    public class Product
    {
        public Product() { }
      public  Product(int id, int CategoryId, string Name){
            this.Id = id;
            this.CategoryId = CategoryId;
            this.Name = Name;
        }
       
        public int Id { get; set; }
        public int CategoryId { get; set; }
       
        public string Name { get; set; }
      
        public string Artikul { get; set; }
     
        public int Price { get; set; }

        public string Material { get; set; }

        public int Length { get; set;}

        public int Weight { get; set; }

        public string Description { get; set; }

        public string imageName { get; set; }


    }
}