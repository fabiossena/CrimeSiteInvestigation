using CrimeSiteInvestigation.Model;
using System.Linq;
using System.Web.Mvc;

namespace CrimeSiteInvestigation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Clue()
        {
            return View();
        }

        public ActionResult Investigation()
        {
            var suspeitos = new SuspeitoModel().GetAll();
            var locais = new LocalModel().GetAll();
            var armas = new ArmaModel().GetAll();

            ViewBag.Suspeitos = suspeitos;
            ViewBag.Locais = locais;
            ViewBag.Armas = armas;
            
            new InvestigacaoModel().InicialNovoJogo(
                                suspeitos.Count(),
                                locais.Count(),
                                armas.Count());

            return View();
        }

        [HttpGet]
        public ActionResult TentarResolver(int suspeito, int local, int arma)
        {
            var tentativa = new InvestigacaoModel().TentarResolver(suspeito, local, arma);
            return Json(new { Success = true, Tentativa = tentativa }, JsonRequestBehavior.AllowGet);
        }
        
    }
}