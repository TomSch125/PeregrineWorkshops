using ProductsApp.Context;
using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ProductsApp.Controllers
{
    public class FeedbackController : Controller
    {
        private ProductContext db = new ProductContext();


        // GET: Feedback/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Feedback/Create
        [HttpPost]
        public ActionResult Create(Feedback feedback)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Feedbacks.Add(feedback);
                    db.SaveChanges();
                    return RedirectToAction("Index", "Product" );
                }
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            catch
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
        }

        


    }
}
