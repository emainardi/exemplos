using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class LineController : Controller
    {
        // GET: Line
        public ActionResult Index()
        {
            Dictionary<int, String> businessUnit = Enum.GetValues(typeof(BusinessUnit)).Cast<BusinessUnit>().ToDictionary(t => (int)t, t => t.ToString());

            ViewBag.Business = new SelectList((System.Collections.IEnumerable)businessUnit, "Key", "Value");

            return View();
        }

        [HttpPost]
        public ActionResult Save(Line line) {

            Dictionary<int, String> businessUnit = Enum.GetValues(typeof(BusinessUnit)).Cast<BusinessUnit>().ToDictionary(t => (int)t, t => t.ToString());            

            int SelectValue = line.BusinessUnit == null ? -1 : ((int)line.BusinessUnit);

            ViewBag.Business = new SelectList((System.Collections.IEnumerable)businessUnit, "Key", "Value", SelectValue);

            return View("View", line);
        }

        [HttpPost]
        public ActionResult Edit(Line line)
        {
            Dictionary<int, String> businessUnit = Enum.GetValues(typeof(BusinessUnit)).Cast<BusinessUnit>().ToDictionary(t => (int)t, t => t.ToString());

            ViewBag.Business = new SelectList((System.Collections.IEnumerable)businessUnit, "Key", "Value");

            ViewBag.select = line.BusinessUnit.ToString();            

            return View("Index");
        }
    }
}