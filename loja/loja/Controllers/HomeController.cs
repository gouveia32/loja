using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace loja.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Servico()
        {
            ViewBag.Message = "Serviço.";

            return View();
        }

        public ActionResult Localizacao()
        {
            ViewBag.Message = "Localizaçao.";

            return View();
        }

        public ActionResult Contato()
        {
            ViewBag.Message = "Contato.";

            return View();
        }
    }
}