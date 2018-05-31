﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace catalogacionMuba.Models
{
    public class Propietario
    {   
        [Key]
        public int ID_prop { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Obra> Obras { get; set; }
    }

}