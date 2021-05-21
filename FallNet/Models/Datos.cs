using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FallNet.Models
{
    public class Datos
    {
        [Key, Column(Order = 1)]
        public int DatosID { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Minimo 2 caracteres maximo 50")]
        [DataType(DataType.Text)]
        public string oc { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Minimo 2 caracteres maximo 50")]
        [DataType(DataType.Text)]
        public string f12 { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Minimo 2 caracteres maximo 50")]
        [DataType(DataType.Text)]
        public string sku { get; set; }

        [Required(ErrorMessage = "{0} requerido")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Minimo 2 caracteres maximo 50")]
        [DataType(DataType.Text)]
        public string cc { get; set; }

        [StringLength(50, MinimumLength = 2, ErrorMessage = "Minimo 2 caracteres maximo 50")]
        [DataType(DataType.Text)]
        public string estado { get; set; }

        public virtual Cancelaciones Cancelaciones { get; set; }
    }
}