//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoReservaTicket.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Reserva
    {
        public int ReservaID { get; set; }
        [Display(Name = "Fecha Reserva")]
        public System.DateTime FechaReserva { get; set; }
        [Display(Name = "Evento")]
        public int EventoID { get; set; }
        [Display(Name = "Nombre y Apellido")]
        public string NombreAepllido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        [Display(Name = "Cantidad Ticket")]
        public int CantidadTicket { get; set; }
        [Display(Name = "Total a Pagar")]
        public decimal TotalPagar { get; set; }

        public virtual Evento Evento { get; set; }
       
    }
}
