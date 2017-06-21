using HomeWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWork1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Produce> ListProduce = new List<Produce>();
            Produce ProduceA = new Produce { Type = MyType.Expend, Date = DateTime.Parse("2017-11-12"), Money = 800 };
            Produce ProduceB = new Produce { Type = MyType.Expend, Date = DateTime.Parse("2017-10-12"), Money = 1700 };
            Produce ProduceC = new Produce { Type = MyType.Expend, Date = DateTime.Parse("2017-9-12"), Money = 400 };
            ListProduce.Add(ProduceA);
            ListProduce.Add(ProduceB);
            ListProduce.Add(ProduceC);
            return View(ListProduce);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}