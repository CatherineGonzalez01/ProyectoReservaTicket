using ProyectoReservaTicket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoReservaTicket.Controllers
{
    public class ReservaController : Controller
    {
        // GET: Reserva
        private ReservaTicketEntities db = new ReservaTicketEntities();
        public ActionResult Index()
        {
            return View(db.Reserva.ToList());
        }

        // GET: Eventos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Eventos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ReservaID,FechaReserva,EventoID,NombreAepllido,Direccion,Telefono,Email,CantidadTicket,TotalPagar")] Reserva reserva)
        {
            if (ModelState.IsValid)
            {
                db.Reserva.Add(reserva);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(reserva);
        }
    }
}