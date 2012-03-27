using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspMvc_Mysql_app.Models;
using AspMvc_Mysql_app.Helpers;

namespace AspMvc_Mysql_app.Controllers
{ 
    public class ArticleController : Controller
    {
        private MysqlContext db = new MysqlContext();

        //
        // GET: /Article/

        public ViewResult Index()
        {
            return View(db.Articles.ToList());
        }

        //
        // GET: /Article/Details/5

        public ViewResult Details(int id)
        {
            Article article = db.Articles.Find(id);
            return View(article);
        }

        //
        // GET: /Article/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Article/Create

        [HttpPost]
        public ActionResult Create(Article article)
        {
            if (ModelState.IsValid)
            {
                db.Articles.Add(article);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(article);
        }
        
        //
        // GET: /Article/Edit/5
 
        public ActionResult Edit(int id)
        {
            Article article = db.Articles.Find(id);
            return View(article);
        }

        //
        // POST: /Article/Edit/5

        [HttpPost]
        public ActionResult Edit(Article article)
        {
            if (ModelState.IsValid)
            {
                db.Entry(article).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(article);
        }

        //
        // GET: /Article/Delete/5
 
        public ActionResult Delete(int id)
        {
            Article article = db.Articles.Find(id);
            return View(article);
        }

        //
        // POST: /Article/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Article article = db.Articles.Find(id);
            db.Articles.Remove(article);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}