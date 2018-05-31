using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using catalogacionMuba.Models;

namespace catalogacionMuba.ViewModels
{
    public class ObraVM
    {
        public Obra Obra { get; set; }
        public List<Localizacion> Localizacions { get; set; }
        public List<Propietario> Propietarios { get; set; }
    }
}