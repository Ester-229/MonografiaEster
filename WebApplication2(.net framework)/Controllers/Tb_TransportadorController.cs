using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication2_.net_framework_.Models;

namespace WebApplication2_.net_framework_.Controllers
{
    public class Tb_TransportadorController : Controller
    {
        private Model1 db = new Model1();

        // GET: Tb_Transportador
        public ActionResult Index()
        {
            var tb_Transportador = db.Tb_Transportador.Include(t => t.Tb_Area_Actuacao).Include(t => t.Tb_Estado).Include(t => t.tb_Tipo_Veiculo).Include(t => t.Tb_Unidade_de_Medida).Include(t => t.Tb_Usuarios);
            return View(tb_Transportador.ToList());
        }

        // GET: Tb_Transportador/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_Transportador tb_Transportador = db.Tb_Transportador.Find(id);
            if (tb_Transportador == null)
            {
                return HttpNotFound();
            }
            return View(tb_Transportador);
        }

        // GET: Tb_Transportador/Create
        public ActionResult Create()
        {
            ViewBag.Id_Area_Actuacao = new SelectList(db.Tb_Area_Actuacao, "ID_Area_Actuacao", "Area_Actuacao");
            ViewBag.Id_Estado = new SelectList(db.Tb_Estado, "ID_Estado", "Estado");
            ViewBag.Id_Tipo_Veiculo = new SelectList(db.tb_Tipo_Veiculo, "Id_Tipo_Veiculo", "Tipo_Veiculo");
            ViewBag.Capacidade_de_Carga = new SelectList(db.Tb_Unidade_de_Medida, "Id_Unidade", "Unidade_de_Medida");
            ViewBag.Id_Usuario = new SelectList(db.Tb_Usuarios, "Id_Usuario", "Nome");
            Tb_Transportador tb_Transportador = new Tb_Transportador();
            return View(tb_Transportador);
        }

        // POST: Tb_Transportador/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id_Transportador,Id_Tipo_Veiculo,Id_Area_Actuacao,Capacidade_de_Carga,Preco,Imagem,Id_Usuario,Id_Estado")] Tb_Transportador tb_Transportador)
        {
            if (ModelState.IsValid)
            {
                if (tb_Transportador.ImageUpload != null)
                {
                    string fileName = Path.GetFileNameWithoutExtension(tb_Transportador.ImageUpload.FileName);
                    string extension = Path.GetExtension(tb_Transportador.ImageUpload.FileName);
                    fileName = fileName + extension;
                    tb_Transportador.Imagem = "~/Content/Imagem/" + fileName;
                    tb_Transportador.ImageUpload.SaveAs(Path.Combine(Server.MapPath("~/Content/Imagem/"), fileName));
                }
                db.Tb_Transportador.Add(tb_Transportador);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Id_Area_Actuacao = new SelectList(db.Tb_Area_Actuacao, "ID_Area_Actuacao", "Area_Actuacao", tb_Transportador.Id_Area_Actuacao);
            ViewBag.Id_Estado = new SelectList(db.Tb_Estado, "ID_Estado", "Estado", tb_Transportador.Id_Estado);
            ViewBag.Id_Tipo_Veiculo = new SelectList(db.tb_Tipo_Veiculo, "Id_Tipo_Veiculo", "Tipo_Veiculo", tb_Transportador.Id_Tipo_Veiculo);
            ViewBag.Capacidade_de_Carga = new SelectList(db.Tb_Unidade_de_Medida, "Id_Unidade", "Unidade_de_Medida", tb_Transportador.Capacidade_de_Carga);
            ViewBag.Id_Usuario = new SelectList(db.Tb_Usuarios, "Id_Usuario", "Nome", tb_Transportador.Id_Usuario);
            return View(tb_Transportador);
        }

        // GET: Tb_Transportador/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_Transportador tb_Transportador = db.Tb_Transportador.Find(id);
            if (tb_Transportador == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id_Area_Actuacao = new SelectList(db.Tb_Area_Actuacao, "ID_Area_Actuacao", "Area_Actuacao", tb_Transportador.Id_Area_Actuacao);
            ViewBag.Id_Estado = new SelectList(db.Tb_Estado, "ID_Estado", "Estado", tb_Transportador.Id_Estado);
            ViewBag.Id_Tipo_Veiculo = new SelectList(db.tb_Tipo_Veiculo, "Id_Tipo_Veiculo", "Tipo_Veiculo", tb_Transportador.Id_Tipo_Veiculo);
            ViewBag.Capacidade_de_Carga = new SelectList(db.Tb_Unidade_de_Medida, "Id_Unidade", "Unidade_de_Medida", tb_Transportador.Capacidade_de_Carga);
            ViewBag.Id_Usuario = new SelectList(db.Tb_Usuarios, "Id_Usuario", "Nome", tb_Transportador.Id_Usuario);
            return View(tb_Transportador);
        }

        // POST: Tb_Transportador/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id_Transportador,Id_Tipo_Veiculo,Id_Area_Actuacao,Capacidade_de_Carga,Preco,Imagem,Id_Usuario,Id_Estado")] Tb_Transportador tb_Transportador)
        {
            if (ModelState.IsValid)
            {
                if (tb_Transportador.ImageUpload != null)
                {
                    string fileName = Path.GetFileNameWithoutExtension(tb_Transportador.ImageUpload.FileName);
                    string extension = Path.GetExtension(tb_Transportador.ImageUpload.FileName);
                    fileName = fileName + extension;
                    tb_Transportador.Imagem = "~/Content/Imagem/" + fileName;
                    tb_Transportador.ImageUpload.SaveAs(Path.Combine(Server.MapPath("~/Content/Imagem/"), fileName));
                }
                db.Entry(tb_Transportador).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Id_Area_Actuacao = new SelectList(db.Tb_Area_Actuacao, "ID_Area_Actuacao", "Area_Actuacao", tb_Transportador.Id_Area_Actuacao);
            ViewBag.Id_Estado = new SelectList(db.Tb_Estado, "ID_Estado", "Estado", tb_Transportador.Id_Estado);
            ViewBag.Id_Tipo_Veiculo = new SelectList(db.tb_Tipo_Veiculo, "Id_Tipo_Veiculo", "Tipo_Veiculo", tb_Transportador.Id_Tipo_Veiculo);
            ViewBag.Capacidade_de_Carga = new SelectList(db.Tb_Unidade_de_Medida, "Id_Unidade", "Unidade_de_Medida", tb_Transportador.Capacidade_de_Carga);
            ViewBag.Id_Usuario = new SelectList(db.Tb_Usuarios, "Id_Usuario", "Nome", tb_Transportador.Id_Usuario);
            return View(tb_Transportador);
        }

        // GET: Tb_Transportador/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_Transportador tb_Transportador = db.Tb_Transportador.Find(id);
            if (tb_Transportador == null)
            {
                return HttpNotFound();
            }
            return View(tb_Transportador);
        }

        // POST: Tb_Transportador/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tb_Transportador tb_Transportador = db.Tb_Transportador.Find(id);
            db.Tb_Transportador.Remove(tb_Transportador);
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
