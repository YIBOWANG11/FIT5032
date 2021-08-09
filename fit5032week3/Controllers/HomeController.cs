using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using fit5032week3.HelloWorld;
using System.Web.Mvc;
using fit5032week3.Execise;

namespace fit5032week3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
           
            Hello hello = new Hello();
            ViewBag.Message = hello.GetHello();
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            ExampleDictionary ed = new ExampleDictionary();

            ed.Example();

            return View();
        }
    }
}