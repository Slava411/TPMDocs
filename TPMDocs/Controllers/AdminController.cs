using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TPMDocs.Models;

namespace TPMDocs.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        TPMDocContext db = new TPMDocContext();
        // GET: Admin
        public ActionResult Index()
        {
            //var s = db.Работники;
            return View();
        }
        public ActionResult Indexcreate()
        {
            //var s = db.Работники;
            return View();
        }
        public ActionResult Users()
        {
            var s = db.Работники;
            return PartialView(s);
        }
        public JsonResult JsonSearch()
        {
            var jsondata = db.Работники.ToList<Работники>();
            return Json(jsondata, JsonRequestBehavior.AllowGet);
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}