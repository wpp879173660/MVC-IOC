using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using MODEL;
using IDAL;
using Ninject;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        protected override void Dispose(bool disposing)
        {
            //db.Dispose();
            base.Dispose(disposing);
        }
        [Inject]
        public ia db { get; set; }
        // GET: Home
        [OutputCache(Duration = 120)]
        public ActionResult Index()
        {
            //db.add(new a() { name=111 });
            return View(db.getall());
        }


        public ActionResult aa() {
            return View();
        }

        public ActionResult bb()
        {
            return View();
        }

    }
}