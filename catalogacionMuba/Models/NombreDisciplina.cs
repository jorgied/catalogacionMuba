using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace catalogacionMuba.Models
{
    public enum NombreDisciplina
    {
        [Display(Name = "Dibujo")]
        Dibujo = 1,
        [Display(Name = "Pintura")]
        Pintura = 2,
        [Display(Name = "Grabado")]
        Grabado = 3,
    }
}