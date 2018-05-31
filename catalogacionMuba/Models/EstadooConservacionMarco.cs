using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace catalogacionMuba.Models
{
    public enum EstadooConservacionMarco
    {
        [Display(Name = "Bueno")]
        Bueno = 1,
        [Display(Name = "Regular")]
        Regular = 2,
        [Display(Name = "Malo")]
        Malo = 3, 

    }
}