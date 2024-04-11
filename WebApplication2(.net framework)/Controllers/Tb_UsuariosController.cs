using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebApplication2_.net_framework_.Models;

namespace WebApplication2_.net_framework_.Controllers
{
    public class Tb_UsuariosController : Controller
    {
        Model1 db = new Model1();


        public ActionResult Login(string returnUrl)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login([Bind(Include = "Username, Senha")] Login UserData, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var login = db.Tb_Usuarios.FirstOrDefault(u => u.Username == UserData.Username && u.Senha == UserData.Senha);
                if (login != null)
                {
                    var Tickect = new FormsAuthenticationTicket(login.Username, true, 3000);
                    string Encrypt = FormsAuthentication.Encrypt(Tickect);
                    var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, Encrypt);
                    cookie.Expires = DateTime.Now.AddHours(3000);
                    cookie.HttpOnly = true;
                    Response.Cookies.Add(cookie);
                    FormsAuthentication.SetAuthCookie(login.Username, false);
                    //se houver uma URL que ele estava para ir, sera redirecionada
                    if (Url.IsLocalUrl(returnUrl))
                    {

                        return RedirectToAction(returnUrl);
                    }

                    else
                    {
                        //Session["Imagem_Perfil"] = UserData.Imagem_Perfil;
                        //Session["Imagem_Perfil"] = db.Tb_Usuario.Single(i => i.Username == UserData.Imagem_Perfil).Imagem_Perfil;
                        //permitir que no momento de autenticação do usuario, apareça o seu nome na tela do usuario
                        Session["Id_Usuario"] = UserData.Username;
                        if (login.Tb_tipo_Usuarios.tipo_Usuario == "Admin")
                        {
                            return RedirectToAction("Admin", "Home");
                        }
                        else if (login.Tb_tipo_Usuarios.tipo_Usuario ==   "Comprador")
                        {
                            return RedirectToAction("Comprador", "Home");
                        }
                        else if (login.Tb_tipo_Usuarios.tipo_Usuario == "Vendedor")
                        {
                            return RedirectToAction("Vendedor", "Home");
                        }
                        else if (login.Tb_tipo_Usuarios.tipo_Usuario == "Transportador")
                        {
                            return RedirectToAction("Transportador", "Home");
                        }

                    }

                }

                TempData["msg"] = "Dados errado, digite novamente!";
            }

            return View();
        }

        public ActionResult Logout()
        {
            Session.Clear();

            return RedirectToAction("Login", "Tb_Usuarios");
        }



        // GET: Tb_Usuarios
        public ActionResult Index()
        {
            var tb_Usuarios = db.Tb_Usuarios.Include(t => t.Tb_Municipios).Include(t => t.Tb_tipo_Usuarios);
            return View(tb_Usuarios.ToList());
        }

        // GET: Tb_Usuarios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_Usuarios tb_Usuarios = db.Tb_Usuarios.Find(id);
            if (tb_Usuarios == null)
            {
                return HttpNotFound();
            }
            return View(tb_Usuarios);
        }

        // GET: Tb_Usuarios/Create
        public ActionResult Create()
        {
            ViewBag.Id_Municipio = new SelectList(db.Tb_Municipios, "Id_Municipio", "Municipio");
            ViewBag.Id_tipo_Usuario = new SelectList(db.Tb_tipo_Usuarios, "Id_tipo_Usuario", "tipo_Usuario");
            Tb_Usuarios tb_Usuarios = new Tb_Usuarios();
            return View(tb_Usuarios);
        }

        // POST: Tb_Usuarios/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( Tb_Usuarios tb_Usuarios)
        {
            if (ModelState.IsValid)
            {
                if (tb_Usuarios.ImageUpload != null)
                {
                    string fileName = Path.GetFileNameWithoutExtension(tb_Usuarios.ImageUpload.FileName);
                    string extension = Path.GetExtension(tb_Usuarios.ImageUpload.FileName);
                    fileName = fileName + extension;
                    tb_Usuarios.Foto = "~/Content/Imagem/" + fileName;
                    tb_Usuarios.ImageUpload.SaveAs(Path.Combine(Server.MapPath("~/Content/Imagem/"), fileName));
                }
                db.Tb_Usuarios.Add(tb_Usuarios);
                db.SaveChanges();
                return RedirectToAction("Login", "Tb_Usuarios");
            }

            ViewBag.Id_Municipio = new SelectList(db.Tb_Municipios, "Id_Municipio", "Municipio", tb_Usuarios.Id_Municipio);
            ViewBag.Id_tipo_Usuario = new SelectList(db.Tb_tipo_Usuarios, "Id_tipo_Usuario", "tipo_Usuario", tb_Usuarios.Id_tipo_Usuario);
            return View(tb_Usuarios);
        }

        // GET: Tb_Usuarios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_Usuarios tb_Usuarios = db.Tb_Usuarios.Find(id);
            if (tb_Usuarios == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id_Municipio = new SelectList(db.Tb_Municipios, "Id_Municipio", "Municipio", tb_Usuarios.Id_Municipio);
            ViewBag.Id_tipo_Usuario = new SelectList(db.Tb_tipo_Usuarios, "Id_tipo_Usuario", "tipo_Usuario", tb_Usuarios.Id_tipo_Usuario);

            return View(db.Tb_Usuarios.Where(u => u.Id_Usuario == id).FirstOrDefault());
            //return View(tb_Usuarios);
        }

        // POST: Tb_Usuarios/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( Tb_Usuarios tb_Usuarios)
        {
            if (ModelState.IsValid)
            {
                if (tb_Usuarios.ImageUpload != null)
                {
                    string fileName = Path.GetFileNameWithoutExtension(tb_Usuarios.ImageUpload.FileName);
                    string extension = Path.GetExtension(tb_Usuarios.ImageUpload.FileName);
                    fileName = fileName + extension;
                    tb_Usuarios.Foto = "~/Content/Imagem/" + fileName;
                    tb_Usuarios.ImageUpload.SaveAs(Path.Combine(Server.MapPath("~/Content/Imagem/"), fileName));
                }
                db.Entry(tb_Usuarios).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Id_Municipio = new SelectList(db.Tb_Municipios, "Id_Municipio", "Municipio", tb_Usuarios.Id_Municipio);
            ViewBag.Id_tipo_Usuario = new SelectList(db.Tb_tipo_Usuarios, "Id_tipo_Usuario", "tipo_Usuario", tb_Usuarios.Id_tipo_Usuario);
            return View(tb_Usuarios);
        }

        // GET: Tb_Usuarios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_Usuarios tb_Usuarios = db.Tb_Usuarios.Find(id);
            if (tb_Usuarios == null)
            {
                return HttpNotFound();
            }
            return View(tb_Usuarios);
        }

        // POST: Tb_Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tb_Usuarios tb_Usuarios = db.Tb_Usuarios.Find(id);
            db.Tb_Usuarios.Remove(tb_Usuarios);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
