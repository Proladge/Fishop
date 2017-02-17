using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebSite2.Models
{
    public class Order
    {
        // ID покупки
        public int OrderId { get; set; }
        // имя и фамилия покупателя
        public string UserName { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        // адрес покупателя
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        // ID 
        public int ProductID{ get; set; }
        public int ProductPrice { get; set; }
        public int Quantity { get; set; }
        public int Total { get; set; }
        public void Total_count() {
            this.Total = this.Quantity * this.ProductPrice;
                }
        // дата покупки
        public DateTime Date { get; set; }
    }
}