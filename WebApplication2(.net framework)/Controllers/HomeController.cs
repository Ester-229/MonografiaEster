using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebApplication2_.net_framework_.Models;
using WebApplication2_.net_framework_.Models.ModelViews;

namespace WebApplication2_.net_framework_.Controllers
{
    public class HomeController : Controller
    {
       Model1 db = new Model1();
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
        public ActionResult Vendedor()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }
        public ActionResult Transportador()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }
        public ActionResult Comprador()
        {
            Viewlistas p = new Viewlistas();
            p.Produtos = db.Tb_Produtor_Produtos.ToList();
            p.transportadors = db.Tb_Transportador.ToList();

            p.usuarios = db.Tb_Usuarios.ToList();
            return View(p);
          
        }
        public ActionResult CadastroProdutos()
        {
            List<Tb_Categoria> categlist = db.Tb_Categoria.ToList();
            ViewBag.categlist = new SelectList(categlist, "Id_Categoria", "Categoria");
            return View();
        }
        public JsonResult GetListCatego(int Id_Categoria)
        {
            db.Configuration.ProxyCreationEnabled = false;
            List<Tb_Produtos> list = db.Tb_Produtos.Where(x => x.Id_Categoria == Id_Categoria).ToList();
            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}