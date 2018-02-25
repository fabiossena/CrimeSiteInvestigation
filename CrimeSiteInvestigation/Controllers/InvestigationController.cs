using CrimeSiteInvestigation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrimeSiteInvestigation.Controllers
{
    public class InvestigationController : Controller
    {
        // GET: Investigation
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]  
        public JsonResult TentarResolver(int suspeito, int local, int arma)
        {
            var tentativa = new InvestigacaoModel().TentarResolver(suspeito, local, arma);
            return Json(new { Success = true, Tentativa = tentativa }, JsonRequestBehavior.AllowGet);
        }
    }
}