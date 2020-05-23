﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NuevoProyecto.Models
{
    public class Datos
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Introduzca un nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Introduzca un Telefono")]
        public string Telefono { get; set; }
        [Required(ErrorMessage ="Introduzca una Cedula")]
        public string Cedula { get; set; }
        [Required(ErrorMessage ="Introduzca una Direccion") ]
        public string Direccion { get; set; }
        [Required(ErrorMessage ="Introduzca una Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        public Datos()
        {
            Id = 0;
            Nombre = string.Empty;
            Telefono = string.Empty;
            Cedula = string.Empty;
            Direccion = string.Empty;
            FechaNacimiento = DateTime.Now;
           
        }
    }
}
