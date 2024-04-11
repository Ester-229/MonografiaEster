using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2_.net_framework_.Models;

namespace WebApplication2_.net_framework_.Controllers
{
    public class UsuarioController : Controller
    {
        Model1 db = new Model1();
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CadastroPessoa()
        {
           
           
            List<Tb_Provincia> provlist = db.Tb_Provincia.ToList();
            ViewBag.provlist = new SelectList(provlist, "Id_Provincia", "Provincia");
            return View();

        }
        public JsonResult GetListProv(int Id_Provincia)
        {
            db.Configuration.ProxyCreationEnabled = false;
            List<Tb_Municipios> list = db.Tb_Municipios.Where(x => x.Id_Provincia == Id_Provincia).ToList();
            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}