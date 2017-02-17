using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyWebSite2.Models;
using MyWebSite2.UTIL;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace MyWebSite2.Controllers
{
        public class HomeController : Controller
        {
        // создаем контекст данных
        FishopDbContext db = new FishopDbContext();
        public ActionResult Rods()
        {
            return View(db.Rods);
        }
            public ActionResult Index()
            {            
            return View(db.Rods.Where(p=>p.Price > 500));
        }
        [HttpGet]
        public ActionResult Buy(Cart cart)
        {
            if (cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Извините, ваша корзина пуста!");
                  }
            return View();
        }
        [HttpPost]
        public void Buy(Cart cart,Order order)
        {
            if (cart.CartIsEmpty()) {
                ModelState.AddModelError("1","Корзина пуста");
            }

            else
            {
                order.Date = DateTime.Now;
                foreach (var l in cart.Lines)
                {
                    order.ProductID = l.Product.Id;
                    order.ProductPrice = l.Product.Price;
                    order.Quantity = l.Quantity;
                    order.Total = l.Product.Price * l.Quantity;

                    // добавляем информацию о покупке в базу данных
                    db.Orders.Add(order);
                    // сохраняем в бд все изменения
                    db.SaveChanges();

                }
                cart.Clear();
            }
            Response.Redirect("/Home/Bought/" + order.Email + "/"+ order.Firstname + "/" + order.LastName );
        }

        

        public ActionResult Bought(string FirstName, string Lastname, string Email) {
            ViewBag.orderFirstName = FirstName;
            ViewBag.orderLastName = Lastname;
            ViewBag.orderEmail = Email;
            return View();
        }

        /*public async Task <ActionResult> Reviews() {

            MongoContext mongo = new MongoContext();
            var collection = mongo.database.GetCollection<ReviewMongo>("reviews");
            var filter = new BsonDocument();
            var reviews = await collection.Find(filter).ToListAsync();

            reviews.OrderBy(p=>p.Date);

            return View(reviews);
        } */

        public ActionResult Reviews() {
            return View(db.Reviews);
        }

                
        public ActionResult AddReview() {
            return View();
        }
        

        [HttpPost]
        public void AddReview(Review review)
        {


            review.Date = DateTime.Now;
            db.Reviews.Add(review);
            db.SaveChanges();


            


/*
            MongoContext mongo = new MongoContext();
            var collection = mongo.database.GetCollection<BsonDocument>("reviews");
            BsonDocument reviewBson = new BsonDocument
            {
                {"Name", review.Name },
                {"Phone", review.Phone},
                {"ReviewText", review.reviewText},
                {"Date", DateTime.Now}
            };
             collection.InsertOneAsync(reviewBson);
             */

            Response.Redirect("/Home/Reviews");

        }
       
        public ActionResult Katushki()
        {
            return View(db.Reels);
        }

        public ActionResult Contact() {
            return View();
        }


    }
    }