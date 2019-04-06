using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCparcial1p.Models;

namespace MVCparcial1p.Controllers
{
    public class AdrianaBustillosFriendsController : Controller
    {
        private DataContext db = new DataContext();

        // GET: AdrianaBustillosFriends
        public ActionResult Index()
        {
            return View(db.AdrianaBustillosFriendss.ToList());
        }

        // GET: AdrianaBustillosFriends/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdrianaBustillosFriend adrianaBustillosFriend = db.AdrianaBustillosFriendss.Find(id);
            if (adrianaBustillosFriend == null)
            {
                return HttpNotFound();
            }
            return View(adrianaBustillosFriend);
        }

        // GET: AdrianaBustillosFriends/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdrianaBustillosFriends/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FriendlD,NombreCompleto,Apodo,Cumpleaños,TipoDeAmigo,Estado")] AdrianaBustillosFriend adrianaBustillosFriend)
        {
            if (ModelState.IsValid)
            {
                db.AdrianaBustillosFriendss.Add(adrianaBustillosFriend);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(adrianaBustillosFriend);
        }

        // GET: AdrianaBustillosFriends/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdrianaBustillosFriend adrianaBustillosFriend = db.AdrianaBustillosFriendss.Find(id);
            if (adrianaBustillosFriend == null)
            {
                return HttpNotFound();
            }
            return View(adrianaBustillosFriend);
        }

        // POST: AdrianaBustillosFriends/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FriendlD,NombreCompleto,Apodo,Cumpleaños,TipoDeAmigo,Estado")] AdrianaBustillosFriend adrianaBustillosFriend)
        {
            if (ModelState.IsValid)
            {
                db.Entry(adrianaBustillosFriend).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(adrianaBustillosFriend);
        }

        // GET: AdrianaBustillosFriends/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdrianaBustillosFriend adrianaBustillosFriend = db.AdrianaBustillosFriendss.Find(id);
            if (adrianaBustillosFriend == null)
            {
                return HttpNotFound();
            }
            return View(adrianaBustillosFriend);
        }

        // POST: AdrianaBustillosFriends/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AdrianaBustillosFriend adrianaBustillosFriend = db.AdrianaBustillosFriendss.Find(id);
            db.AdrianaBustillosFriendss.Remove(adrianaBustillosFriend);
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
