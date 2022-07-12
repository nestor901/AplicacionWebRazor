using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AplicacionWebRazor.Data
{
    public partial class Curso
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Display(Name ="Nombre de Curso")]
        public string NombreCurso { get; set; }
        [Display(Name ="cantidad de clases")]
        public int CantidadClases { get; set; }
        public int Precio { get; set; }
        [Display(Name ="fecha de creación")]
        public DateTime FechaCreacion { get; set; }
    }
}
