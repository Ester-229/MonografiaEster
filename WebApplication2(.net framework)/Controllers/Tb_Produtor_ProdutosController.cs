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
    public class Tb_Produtor_ProdutosController : Controller
    {
        Model1 db = new Model1();

        // GET: Tb_Produtor_Produtos
        public ActionResult Index()
        {
            var tb_Produtor_Produtos = db.Tb_Produtor_Produtos.Include(t => t.Tb_Produtos).Include(t => t.Tb_Produtos1).Include(t => t.Tb_Produtos2).Include(t => t.Tb_Unidade_de_Medida).Include(t => t.Tb_Usuarios);
            return View(tb_Produtor_Produtos.ToList());
        }

        // GET: Tb_Produtor_Produtos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_Produtor_Produtos tb_Produtor_Produtos = db.Tb_Produtor_Produtos.Find(id);
            if (tb_Produtor_Produtos == null)
            {
                return HttpNotFound();
            }
            return View(tb_Produtor_Produtos);
        }

        // GET: Tb_Produtor_Produtos/Create
        public ActionResult Create()
        {
            ViewBag.Id_Produtos = new SelectList(db.Tb_Produtos, "Id_Produto", "Produto");
            ViewBag.Id_Unidade = new SelectList(db.Tb_Unidade_de_Medida, "Id_Unidade", "Unidade_de_Medida");
            ViewBag.Id_Produtor = new SelectList(db.Tb_Usuarios, "Id_Usuario", "Nome");
            Tb_Produtor_Produtos tb_Produtor_Produtos = new Tb_Produtor_Produtos();
            return View(tb_Produtor_Produtos);
           
        }

        // POST: Tb_Produtor_Produtos/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_Produtor_Produtos,ProdutoImg,Id_Produtos,Id_Produtor,Preco,Quantidade_Disponiveis,Id_Unidade,Descricao,Estado,Data_Criacao")] Tb_Produtor_Produtos tb_Produtor_Produtos)
        {
            if (ModelState.IsValid)
            {
                tb_Produtor_Produtos.Data_Criacao = DateTime.Now;
                if (tb_Produtor_Produtos.ImageUpload != null)
                {
                    string fileName = Path.GetFileNameWithoutExtension(tb_Produtor_Produtos.ImageUpload.FileName);
                    string extension = Path.GetExtension(tb_Produtor_Produtos.ImageUpload.FileName);
                    fileName = fileName + extension;
                    tb_Produtor_Produtos.ProdutoImg = "~/Content/Imagem/" + fileName;
                    tb_Produtor_Produtos.ImageUpload.SaveAs(Path.Combine(Server.MapPath("~/Content/Imagem/"), fileName));
                }
                db.Tb_Produtor_Produtos.Add(tb_Produtor_Produtos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Id_Produtos = new SelectList(db.Tb_Produtos, "Id_Produto", "Produto", tb_Produtor_Produtos.Id_Produtos);
            ViewBag.Id_Unidade = new SelectList(db.Tb_Unidade_de_Medida, "Id_Unidade", "Unidade_de_Medida", tb_Produtor_Produtos.Id_Unidade);
            ViewBag.Id_Produtor = new SelectList(db.Tb_Usuarios, "Id_Usuario", "Nome", tb_Produtor_Produtos.Id_Produtor);
            return View(tb_Produtor_Produtos);
        }

        // GET: Tb_Produtor_Produtos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_Produtor_Produtos tb_Produtor_Produtos = db.Tb_Produtor_Produtos.Find(id);
            if (tb_Produtor_Produtos == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id_Produtos = new SelectList(db.Tb_Produtos, "Id_Produto", "Produto", tb_Produtor_Produtos.Id_Produtos);
            ViewBag.Id_Unidade = new SelectList(db.Tb_Unidade_de_Medida, "Id_Unidade", "Unidade_de_Medida", tb_Produtor_Produtos.Id_Unidade);
            ViewBag.Id_Produtor = new SelectList(db.Tb_Usuarios, "Id_Usuario", "Nome", tb_Produtor_Produtos.Id_Produtor);
            return View(tb_Produtor_Produtos);
        }

        // POST: Tb_Produtor_Produtos/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_Produtor_Produtos,ProdutoImg,Id_Produtos,Id_Produtor,Preco,Quantidade_Disponiveis,Id_Unidade,Descricao,Estado,Data_Criacao")] Tb_Produtor_Produtos tb_Produtor_Produtos)
        {
            if (ModelState.IsValid)
            {
                tb_Produtor_Produtos.Data_Criacao = DateTime.Now;
                if (tb_Produtor_Produtos.ImageUpload != null)
                {
                    string fileName = Path.GetFileNameWithoutExtension(tb_Produtor_Produtos.ImageUpload.FileName);
                    string extension = Path.GetExtension(tb_Produtor_Produtos.ImageUpload.FileName);
                    fileName = fileName + extension;
                    tb_Produtor_Produtos.ProdutoImg = "~/Content/Imagem/" + fileName;
                    tb_Produtor_Produtos.ImageUpload.SaveAs(Path.Combine(Server.MapPath("~/Content/Imagem/"), fileName));
                }
                db.Entry(tb_Produtor_Produtos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Id_Produtos = new SelectList(db.Tb_Categoria, "Id_Categoria", "Categoria");
            ViewBag.Id_Produtos = new SelectList(db.Tb_Produtos, "Id_Produto", "Produto", tb_Produtor_Produtos.Id_Produtos);
            ViewBag.Id_Unidade = new SelectList(db.Tb_Unidade_de_Medida, "Id_Unidade", "Unidade_de_Medida", tb_Produtor_Produtos.Id_Unidade);
            ViewBag.Id_Produtor = new SelectList(db.Tb_Usuarios, "Id_Usuario", "Nome", tb_Produtor_Produtos.Id_Produtor);
            return View(tb_Produtor_Produtos);
        }

        // GET: Tb_Produtor_Produtos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tb_Produtor_Produtos tb_Produtor_Produtos = db.Tb_Produtor_Produtos.Find(id);
            if (tb_Produtor_Produtos == null)
            {
                return HttpNotFound();
            }
            return View(tb_Produtor_Produtos);
        }

        // POST: Tb_Produtor_Produtos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tb_Produtor_Produtos tb_Produtor_Produtos = db.Tb_Produtor_Produtos.Find(id);
            db.Tb_Produtor_Produtos.Remove(tb_Produtor_Produtos);
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
