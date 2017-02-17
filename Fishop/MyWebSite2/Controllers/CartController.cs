using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyWebSite2.Models;

namespace MyWebSite2.Controllers
{
    public class CartController : Controller
    {
        FishopDbContext db = new FishopDbContext();
        [HttpPost]
        public RedirectToRouteResult AddToCart(Cart cart, int productId, int CategoryId, string returnUrl)
        {
            Product product = new Product();
            if (CategoryId == 1)
            {
                 product = db.Rods
                    .FirstOrDefault(p => p.Id == productId);
            }

            if (CategoryId == 2)
            {
                product = db.Reels
                    .FirstOrDefault(p => p.Id == productId);
            }

        
            if (product != null)
            {
                cart.AddItem(product, 1);
            }
            ViewBag.returnurl = returnUrl;
            return RedirectToAction("CartIndex", new { returnUrl });
        }
        [HttpPost]
        public RedirectToRouteResult RemoveFromCart(Cart cart, int productId, string returnUrl)
        {
            Product product = db.Rods
                .FirstOrDefault(g => g.Id == productId);

            if (product != null)
            {
                cart.RemoveLine(product);
            }
            return RedirectToAction("CartIndex", new { returnUrl });
        }

        

        public ViewResult CartIndex(Cart cart, string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = cart,
                ReturnUrl = returnUrl
            });
        }

        public PartialViewResult Summary(Cart cart) {
            return PartialView(cart);
           }

  

    }

}