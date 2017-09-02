using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Client.FirstWCFServiceReference;

namespace Client.Controllers
{
    public class HomeController : Controller
    {
        FirstWCFServiceClient client = new FirstWCFServiceClient();
        public ActionResult Index()
        {
            ViewBag.Message = client.Message();
            int x = client.add(5, 10);

            ViewBag.X = x;
            return View();
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