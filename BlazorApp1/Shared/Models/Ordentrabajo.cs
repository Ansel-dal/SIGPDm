﻿using System;
using System.Collections.Generic;

namespace BlazorApp1.Shared.Models
{
    public partial class Ordentrabajo
    {
        public int Id { get; set; }
        public string? Cliente { get; set; }
        public DateTime? Fechaentrega { get; set; }
        public string? Descripcion { get; set; }
        public string? Lugarentrega { get; set; }
        public string? Especificaciones { get; set; }
        public string? Estado { get; set; }
        public string? Planos { get; set; }
        public string? Codigo { get; set; }
        public string? Despiece { get; set; }
        public DateTime? Pedidofabrica { get; set; }
        public string? Cantidad { get; set; }
        public string? Observaciones { get; set; }
        public string? Fechas { get; set; }
    }
}
