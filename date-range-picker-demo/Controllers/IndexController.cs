using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace date_range_picker_demo.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index(DateTime? start, DateTime? end)
        {
            ViewBag.DateStart = start;
            ViewBag.DateEnd = end;
            return View();
        }
    }
}