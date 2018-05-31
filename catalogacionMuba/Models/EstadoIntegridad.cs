using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace catalogacionMuba.Models
{
    public enum EstadoIntegridad
    {
        [Display(Name = "Completo")]
        Completo = 1,
            [Display(Name = "Incompleto")]
        Incompleto = 2,
            [Display(Name = "Fragmentado")]
        Fragmentado = 3,
            [Display(Name = "Unido")]
        Unido = 4,
            [Display(Name = "Agragado")]
        Agregado = 5,
            [Display(Name = "Descosido")]
        Descosido = 6,
    }
}