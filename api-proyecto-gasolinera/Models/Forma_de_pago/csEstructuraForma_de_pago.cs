using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api_proyecto_gasolinera.Models.Forma_de_pago
{
    public class csEstructuraForma_de_pago
    {
        public class requestForma_de_pago
        {
            public int idformapago { get; set; }
            public string descripcion { get; set; }

        }

        public class responseForma_de_pago
        {
            public int respuesta { get; set; }
            public string descripcion_respuesta { get; set; }
        }
        public class requestEliminarForma_de_pago
        {
            public int idformapago { get; set; }
        }
    }
}