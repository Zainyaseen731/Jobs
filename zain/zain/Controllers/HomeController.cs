using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using zain.Models;

namespace zain.Controllers
{
    public class HomeController : Controller
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();
        public ActionResult Index()
        {
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
        public ActionResult Addjob()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        public ActionResult available()
        {
            var s = dc.jobs.Select(b => b.jobtype).Distinct().ToList();
            ViewBag.Message = "Your contact page.";
            ViewBag.data1 = s;
            
            
            
            return View();
        }

        public ActionResult add1()
        {
            

            return RedirectToAction("Jobs");
        }

 
        public ActionResult Jobs()
        {
            string textboxValue = Request["cars"];
            ViewBag.name = textboxValue;
            var one = dc.jobs.Where(c => c.jobtype == textboxValue);
            if (one.ToString() != null)
            {
                ViewBag.data = one;
            }
            return View();
        }

        public ActionResult add()
        {
            string type = Request["type"];
            string title = Request["title"];
            string company = Request["company"];
            string location = Request["location"];
            job p = new job();
            p.jobtype = type;
            p.jobtitle = title;
            p.company = company;
            p.location = location;
            dc.jobs.InsertOnSubmit(p);
            dc.SubmitChanges();
            return RedirectToAction("available");
        }

        public ActionResult Edit(int id)
        {
            var c = dc.jobs.First(a => a.Id == id);
            return View(c);
        }

        public ActionResult Done(int id)
        {
            string type = Request["type"];
            string title = Request["title"];
            string company = Request["company"];
            string location = Request["location"];
            var c = dc.jobs.First(a => a.Id == id);
            c.jobtype = type;
            c.jobtitle = title;
            c.company = company;
            c.location = location;
            dc.SubmitChanges();
            return RedirectToAction("available");

        }
    }
}