using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FiordilotoMVC.Models;
using System.Web.Helpers;
using System.IO;

namespace FiordilotoMVC.Controllers
{
    public class EventisController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Eventis
        public ActionResult Index()
        {
            var eventi = db.Eventis.Where(e=>e.Credits == false).OrderByDescending(e => e.Data).ToList();
            ViewBag.EventiCount = eventi.Count();
            return View(eventi);
        }

        // GET: Eventis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Eventi eventi = db.Eventis.Find(id);
            if (eventi == null)
            {
                return HttpNotFound();
            }
            return View(eventi);
        }

        // GET: Eventis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Eventis/Create
        // Per proteggere da attacchi di overposting, abilitare le proprietà a cui eseguire il binding. 
        // Per ulteriori dettagli, vedere https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Evento_Id,Vendita,Didattica,Corso,Titolo,Evidenza,Counseling,Credits,Casa,Data,Archivio,DescrizioneB,Città", Exclude ="Descrizione,Regia,Partecipazioni")] Eventi eventi)
        {
            FormCollection collection = new FormCollection(Request.Unvalidated().Form);
            eventi.Descrizione = collection["Descrizione"];
            eventi.Regia = collection["Regia"];
            eventi.Partecipazioni = collection["Partecipazioni"];
            if (ModelState.IsValid)
            {
                db.Eventis.Add(eventi);
                db.SaveChanges();
                if(!Directory.Exists(Server.MapPath("~/Content/Immagini/Eventi/" + eventi.Evento_Id)))
                {
                Directory.CreateDirectory(Server.MapPath("~/Content/Immagini/Eventi/" + eventi.Evento_Id));
                }
                return RedirectToAction("Index");
            }

            return View(eventi);
        }

        // GET: Eventis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Eventi eventi = db.Eventis.Find(id);
            if (eventi == null)
            {
                return HttpNotFound();
            }
            return View(eventi);
        }

        // POST: Eventis/Edit/5
        // Per proteggere da attacchi di overposting, abilitare le proprietà a cui eseguire il binding. 
        // Per ulteriori dettagli, vedere https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Evento_Id,Vendita,Didattica,Corso,Titolo,Evidenza,Counseling,Credits,Casa,Data,Archivio,DescrizioneB,Città", Exclude = "Descrizione,Regia,Partecipazioni")] Eventi eventi)
        {
            FormCollection collection = new FormCollection(Request.Unvalidated().Form);
            eventi.Descrizione = collection["Descrizione"];
            eventi.Regia = collection["Regia"];
            eventi.Partecipazioni = collection["Partecipazioni"];
            if (ModelState.IsValid)
            {
                db.Entry(eventi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eventi);
        }

        public ActionResult EditCredits(int? id, string cre)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Eventi eventi = db.Eventis.Find(id);
            if (eventi == null)
            {
                return HttpNotFound();
            }
            return View(eventi);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditCredits(string cre, [Bind(Include = "Evento_Id,Vendita,Didattica,Corso,Titolo,Evidenza,Counseling,Credits,Casa,Data,Archivio,DescrizioneB,Posizione,Città", Exclude = "Descrizione")] Eventi eventi)
        {
            FormCollection collection = new FormCollection(Request.Unvalidated().Form);
            eventi.Descrizione = collection["Descrizione"];
            eventi.Regia = collection["Regia"];
            eventi.Partecipazioni = collection["Partecipazioni"];
            if (ModelState.IsValid)
            {
                db.Entry(eventi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction(cre, "Home");

            }
            return View(eventi);
        }


        public ActionResult EditImgIcon()
        {
            return View();
        }

        public ActionResult EditImgSlide()
        {
            return View();
        }

        public ActionResult EditImgGalleria()
        {
            return View();
        }
        // GET: Eventis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Eventi eventi = db.Eventis.Find(id);
            if (eventi == null)
            {
                return HttpNotFound();
            }
            return View(eventi);
        }

        // POST: Eventis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Eventi eventi = db.Eventis.Find(id);
            db.Eventis.Remove(eventi);
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

        public ActionResult DeleteImg(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ViewBag.File = Request.QueryString["file"];
            Eventi eventi = db.Eventis.Find(id);
            if (eventi == null)
            {
                return HttpNotFound();
            }
            return View(eventi);
        }

        [HttpPost, ActionName("DeleteImg")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteImgConfirmed(int id)
        {
            var file = "~/Content/Immagini/Eventi/" + id + "/" + Request.QueryString["file"];
            System.IO.File.Delete(Server.MapPath(file));
            return RedirectToAction("Evento", "Home", new { id = id });

        }


    }
}
