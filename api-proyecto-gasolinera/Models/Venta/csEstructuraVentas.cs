
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

namespace api_proyecto_gasolinera.Models.Ventas
{
    public class CSEstructuraVentas
    {
        public class requestventas
        {
            public string idventa { get; set; }
            public string nit { get; set; }
            public int idempleado { get; set; }
            public int idformapago { get; set; }
            public int idtipogasolina { get; set; }
            public int idbomba { get; set; }
            public DateTime fecha { get; set; }
            public int total_venta { get; set; }

        }
        public class responseVenta
        {
            

            public int respuesta { get; set; }
            public string descripcion_respuesta { get; set; }
        }
        public class requestEliminarVenta
        {
            public string idVenta { get; set; }

        }
    }
}