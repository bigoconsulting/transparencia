﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Transparencia.Controllers
{
	public class HomeController : Controller
	{
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

        public ActionResult Consulta()
        {
            return View();
        }
        public ActionResult SujetoObligado()
        {
            return View();
        }

        public ActionResult Documentos()
        {
            return View();
        }

        public ActionResult Ayuntamiento()
        {
            return View();
        }

        public ActionResult Turismo()
        {
            return View();
        }


        public ActionResult Indicadores()
        {
            return View();
        }
    }
}