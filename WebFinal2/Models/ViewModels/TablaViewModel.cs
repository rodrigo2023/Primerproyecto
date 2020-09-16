using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebFinal2.Models.ViewModels
{
    public class TablaViewModel
    {
        public int id_operacion { get; set; }
        [Display(Name = "Concepto")]
        public string concepto { get; set; }
        [Display(Name = "Monto")]
        public int monto { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Operacion")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime fecha_op { get; set; }
        
        [Display(Name = "Ingrese el Tipo (1 o 2)")]
        public int tipo { get; set; }



    }
}