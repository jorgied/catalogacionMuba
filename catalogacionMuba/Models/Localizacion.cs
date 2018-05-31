using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace catalogacionMuba.Models
{
    public class Localizacion
    {
        [Key]   
        public int Id_loc { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string email { get; set; }
        public string Ubicacion { get; set; }
        [Display(Name = "Nombre")]
        public string Observacion { get; set; }

        public virtual ICollection <Obra> Obras { get; set; }
    }
}