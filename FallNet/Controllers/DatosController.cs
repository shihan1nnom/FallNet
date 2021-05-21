using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using FallNet.Models;

namespace FallNet.Controllers
{
    public class DatosController : Controller
    {
        private ContextoBD _bd = new ContextoBD();

        // GET: Datos
        public ActionResult Index(string buscar)
        {
            var datos = from d in _bd.Datoss select d;
            var cancelar = from c in _bd.Cancelacioness select c;

            dynamic model = new ExpandoObject();
            model.Datos = datos.Where(d => d.f12 == buscar || d.cc == buscar);
            model.Cancelaciones = cancelar.Where(d => d.f12 == buscar);
            return View(model);
        }

    }
}