using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace catalogacionMuba.Models
{
    public class Obra
    {
        //codigo de registro
        public string Cod_reg { get; set; }
        //codigo de la muestra
        public string Cod_mues { get; set; }

        //codigo obra
        [Key]
        public int Cod_obra { get; set; }
        //titulo
        public string Titulo { get; set; }
        //coleccion
        public string Coleccion { get; set; }
        //conjunto/juego
        public string Conjunto { get; set; }
        //serie(grabados)
        public string Serie { get; set; }
        //Autor [Firmado, marcado, atribuido]
        [Required]
        public string Autor { get; set; }
        //Nacionalidad
        public string Nacionalidad { get; set; }
        //pais de origen
        public string Origen { get; set; }
        //fecha/epoca
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Fecha { get; set; }
        //Fechado [sí, no]
        [Display(Name = "Fechado")]
        public bool Fechado { get; set; }
        //regimen de prioridad (comodato|compra|guarda|prestamo|donacion|otro)
        public virtual RegimenPrioridad RegimenPrioridad { get; set;
            
           }
        //procedencia
        public string Procedencia { get; set; }
        //premios/distinciones
        public string Premios { get; set; }
        //observaciones
        //tecnica y material
        public string tecnica { get; set; }
        //soporte
        public string Soporte { get; set; }
        //descripcion preiconografica
        public string DescPreiconografica { get; set; }
        //dimensiones (con marco|del soporte|sin marco)
        public string DimencionMarco { get; set; }
        public string DimSoporte { get; set; }
        public string DimSinMarco { get; set; }
        //tamaño(ancho|alto|profundidad) 
        public string Tamaño { get; set; }
        //inscripciones o marcas
        public string Inscripciones { get; set; }
        //estado de integridad (completo|incompleto|fragmentado|unido|agregado|descosido)
        public virtual EstadoIntegridad EstadoIntegridad { get; set; }

        //estado de conservación obra (bueno|regular|malo)
        public virtual EstadooConservacionObra EstadooConservacionObra  { get; set;  }

        //estado conservacion marco (bueno|regular|malo)

        public virtual EstadooConservacionMarco EstadooConservacionMarco { get; set;    }

        //observaciones de conservación
        public string ObservacionConservacion { get; set; }
        //fotografía frente con marco
        public string FotoFrente { get; set; }
        //fotografia posterior
        public string FotoPost { get; set; }
        //observaciónes
        public string ObservacionesObra { get; set; }
        //analisis obra
        public string AnalisisObra { get; set; }
        //bibliografia consultada
        public string Bibliografia { get; set; }
        //responsable catalogacion
        public string Responsable { get; set; }
        //fecha catalogacion
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime FechaCatalogacion { get; set; }
    
        

        public virtual NombreDisciplina Disciplina  { get; set; }

        //clave foranea de localizacion
        public int Id_loc { get; set; }
        public Localizacion Localizacion { get; set; }

        //clave foranea de Propietario
        public int ID_prop { get; set; }
        public Propietario Propietario { get; set; }

        
    }
}