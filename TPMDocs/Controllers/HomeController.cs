using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TPMDocs.Models;

namespace TPMDocs.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {

        TPMDocContext db = new TPMDocContext();
        public ActionResult Index()
        {

            return View();
        }

        [HttpGet]
        public ActionResult CreateDoc()
        {

            ViewBag.ContractCat = new SelectList(db.tbContractCategories.Where(p=>p.Category==1).OrderBy(p => p.Code), "Code", "Name1");
            return View();
        }

        [HttpPost]
        public ActionResult CreateDoc(DocsContract contract)
        {
            var username = User.Identity.Name;

            var userid = db.Работники.Where(p => p.Login == username).FirstOrDefault().Код;

            contract.DateCreate = DateTime.Now;
            contract.KardId = 1;
            contract.EcontId = userid;
            db.DocsContracts.Add(contract);
            db.SaveChanges();
            return View();
        }
        public ActionResult CreateDocDop(tbContract c, int id= 6279)
        {
            var cont = db.tbContracts.FirstOrDefault(p => p.ContractID == id);
            int cc = db.tbContracts.Max(p => p.ContractID);
            c = cont;
            c.ContractID = cc + 1;
            c.ContractDocNum = cont.ContractDocNum + 1;
            db.tbContracts.Add(c);
            db.SaveChanges();
            return View();
        }

        protected override void Dispose(bool disposing)
        {

            db.Dispose();

            base.Dispose(disposing);
        }
    }


}