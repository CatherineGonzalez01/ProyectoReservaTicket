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
    }
}