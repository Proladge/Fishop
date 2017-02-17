using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyWebSite2.Models;

namespace MyWebSite2.Abstract
{
    public interface IOrderProcessor
    {
        void ProcessOrder(Cart cart, Order order);
    }
}