using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using APIparcial.Models;

namespace APIparcial.Controllers
{
    public class AdrianaBustillosFriendsController : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/AdrianaBustillosFriends
        public IQueryable<AdrianaBustillosFriend> GetAdrianaBustillosFriendss()
        {
            return db.AdrianaBustillosFriendss;
        }

        // GET: api/AdrianaBustillosFriends/5
        [ResponseType(typeof(AdrianaBustillosFriend))]
        public IHttpActionResult GetAdrianaBustillosFriend(int id)
        {
            AdrianaBustillosFriend adrianaBustillosFriend = db.AdrianaBustillosFriendss.Find(id);
            if (adrianaBustillosFriend == null)
            {
                return NotFound();
            }

            return Ok(adrianaBustillosFriend);
        }

        // PUT: api/AdrianaBustillosFriends/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAdrianaBustillosFriend(int id, AdrianaBustillosFriend adrianaBustillosFriend)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != adrianaBustillosFriend.FriendlD)
            {
                return BadRequest();
            }

            db.Entry(adrianaBustillosFriend).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdrianaBustillosFriendExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/AdrianaBustillosFriends
        [ResponseType(typeof(AdrianaBustillosFriend))]
        public IHttpActionResult PostAdrianaBustillosFriend(AdrianaBustillosFriend adrianaBustillosFriend)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.AdrianaBustillosFriendss.Add(adrianaBustillosFriend);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = adrianaBustillosFriend.FriendlD }, adrianaBustillosFriend);
        }

        // DELETE: api/AdrianaBustillosFriends/5
        [ResponseType(typeof(AdrianaBustillosFriend))]
        public IHttpActionResult DeleteAdrianaBustillosFriend(int id)
        {
            AdrianaBustillosFriend adrianaBustillosFriend = db.AdrianaBustillosFriendss.Find(id);
            if (adrianaBustillosFriend == null)
            {
                return NotFound();
            }

            db.AdrianaBustillosFriendss.Remove(adrianaBustillosFriend);
            db.SaveChanges();

            return Ok(adrianaBustillosFriend);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AdrianaBustillosFriendExists(int id)
        {
            return db.AdrianaBustillosFriendss.Count(e => e.FriendlD == id) > 0;
        }
    }
}