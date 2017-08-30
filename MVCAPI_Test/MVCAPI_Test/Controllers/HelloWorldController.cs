using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAPI_Test.Controllers
{
    public class HelloWorldController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }
    
        // 
       // GET: /HelloWorld/ 

       public string Index1()
        {
            return "This is my <b>default</b> action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcomes()
        {
            return "This is the Welcome action method...";
        }

        // GET: HelloWorld/Welcome?name=Scott&numtimes=4 and optional-parameter numTimes

        ///localhost:XXX/HelloWorld/Welcome/Scott/3  -- added new ROUTE
        public string Welcome1(string name, int numTimes = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes);
        }

        //GET http://localhost:xxx/HelloWorld/Welcome/3?name=Rick
        //This time the third URL segment matched the route parameter ID in ROUTECONFIG.CS
        public string Welcome2(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        }
    }
}