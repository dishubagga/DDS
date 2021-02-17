using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Routing;
using System.Web.Mvc.Ajax;
using System.Text.Encodings.Web;


namespace MvcMovie.Controllers
{
    public class HElloWorldController : Controller
    {

        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, numTimes: {numTimes}");

        }
    }
}
