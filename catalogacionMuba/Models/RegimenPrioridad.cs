using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace catalogacionMuba.Models
{
    public enum RegimenPrioridad
    {
        [Display(Name = "Comodato")]
        Comodato = 1,
        [Display(Name = "Compra")]
        Compra = 2,
        [Display(Name = "Guarda")]
        Guarda = 3,
        [Display(Name = "Préstamo")]
        Prestamo = 4,
        [Display(Name = "Donación")]
        Donacion = 5,
        [Display(Name = "Otro")]
        Otro = 6 ,
    }
}