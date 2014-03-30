using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/ 
        public ViewResult Index()
        {
            Greeting();
            return View();
        }

        //action method for the input form
        public ViewResult RsvpForm()
        {
            return View();
        }



        //method for getting the right greeting 
        private void Greeting()
        {
            int hour = DateTime.Now.Hour;
            if (hour < 12)
            {
                ViewBag.Greeting = "Good Morning";
            }
            else if (hour < 18)
            {
                ViewBag.Greeting = "Good Afternoon";
            }
            else
            {
                ViewBag.Greeting = "Good Evening";
            }
        }
    }
}