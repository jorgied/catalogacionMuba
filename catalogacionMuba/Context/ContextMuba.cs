using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace catalogacionMuba.Models.Context
{
    public class ContextMuba : DbContext
    {

        public ContextMuba()
            : base("name=ContextMuba")
        {
        }


        public System.Data.Entity.DbSet<catalogacionMuba.Models.Obra> Obra { get; set; }

        public System.Data.Entity.DbSet<catalogacionMuba.Models.Localizacion> Localizacion { get; set; }

        public System.Data.Entity.DbSet<catalogacionMuba.Models.Propietario> Propietario { get; set; }

        



    }

}