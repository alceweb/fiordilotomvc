using FiordilotoMVC.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using System.Threading.Tasks;


namespace FiordilotoMVC.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            var eventi = db.Eventis.Where(e => e.Evidenza == true).OrderBy(e => e.Data).ToList();
            ViewBag.EventiCount = eventi.Count();
            return View(eventi);
        }

        public ActionResult Evento(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var immagini = Directory.GetFiles(Server.MapPath("/Content/Immagini/Eventi/" + id + "/"));
            ViewBag.Immagini = immagini.ToList();
            Eventi eventi = db.Eventis.Find(id);
            if (eventi == null)
            {
                return HttpNotFound();
            }

            return View(eventi);
        }

        public ActionResult SpettacoliIntro()
        {
            return View();
        }

        public ActionResult Spettacoli() {
            var spettacoli = db.Eventis.Where(e => e.Vendita == true).OrderByDescending(d=>d.Data);
            return View(spettacoli);
        }

        public ActionResult CorsiIntro()
        {
            return View();
        }

        public ActionResult Corsi()
        {
            var corsi = db.Eventis.Where(e => e.Corso == true).OrderByDescending(d => d.Data);
            return View(corsi);
        }

        public ActionResult DidatticaIntro()
        {
            return View();
        }

        public ActionResult Didattica()
        {
            var didattica = db.Eventis.Where(e => e.Didattica == true).OrderByDescending(d => d.Data);
            return View(didattica);
        }

        public ActionResult CounselingIntro()
        {
            return View();
        }

        public ActionResult Counseling()
        {
            var counseling = db.Eventis.Where(e => e.Counseling == true).OrderByDescending(d => d.Data);
            return View(counseling);
        }

        public ActionResult CasaIntro()
        {
            return View();
        }

        public ActionResult Casa()
        {
            
            return View();
        }

        public ActionResult CasaContent()
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
            var eventi = db.Eventis.Where(e => e.Evidenza == true).OrderBy(e => e.Data).ToList();
            ViewBag.EventiCount = eventi.Count();

            return View(eventi);
        }

        public ActionResult FDL()
        {
            return View();
        }
    }
}