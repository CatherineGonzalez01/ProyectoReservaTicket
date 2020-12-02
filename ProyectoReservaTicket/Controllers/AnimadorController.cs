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
using ProyectoReservaTicket.Models;

namespace ProyectoReservaTicket.Controllers
{
    public class AnimadorController : ApiController
    {
        private ReservaTicketEntities db = new ReservaTicketEntities();

        // GET: api/Animador
        public IQueryable<Animador> GetAnimador()
        {
            return db.Animador;
        }

        // GET: api/Animador/5
        [ResponseType(typeof(Animador))]
        public IHttpActionResult GetAnimador(int id)
        {
            Animador animador = db.Animador.Find(id);
            if (animador == null)
            {
                return NotFound();
            }

            return Ok(animador);
        }

        // PUT: api/Animador/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAnimador(int id, Animador animador)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != animador.animadorID)
            {
                return BadRequest();
            }

            db.Entry(animador).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AnimadorExists(id))
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

        // POST: api/Animador
        [ResponseType(typeof(Animador))]
        public IHttpActionResult PostAnimador(Animador animador)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Animador.Add(animador);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (AnimadorExists(animador.animadorID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = animador.animadorID }, animador);
        }

        // DELETE: api/Animador/5
        [ResponseType(typeof(Animador))]
        public IHttpActionResult DeleteAnimador(int id)
        {
            Animador animador = db.Animador.Find(id);
            if (animador == null)
            {
                return NotFound();
            }

            db.Animador.Remove(animador);
            db.SaveChanges();

            return Ok(animador);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AnimadorExists(int id)
        {
            return db.Animador.Count(e => e.animadorID == id) > 0;
        }
    }
}