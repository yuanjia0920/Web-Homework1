using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SubmitForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SubmitForm(Models.GuestResponse guestResponse)
        {
            if(ModelState.IsValid)
            {
                return View("SentCard", guestResponse);
            }
            else
            {
                return View();
            }
        }
    }
}