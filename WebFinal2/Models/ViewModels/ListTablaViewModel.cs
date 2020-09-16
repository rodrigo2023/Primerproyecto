using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFinal2.Models.ViewModels
{
    public class ListTablaViewModel
    {
        public int id_operacion { get; set; }
        public string concepto { get; set; }
        public int monto { get; set; }

        //AGREGADOS
        public int tipo { get; set; }
        
    }
}