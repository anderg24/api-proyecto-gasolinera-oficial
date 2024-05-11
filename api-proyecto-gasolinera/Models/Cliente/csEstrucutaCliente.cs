using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api_proyecto_gasolinera.Models.Cliente
{
    public class csEstructuraCliente
    {
        public class requestCliente
        {
            public int Nit { get; set; }
            public string Nombre { get; set; }
            public string Vehiculo { get; set; }
        }

        public class responseCliente
        {
            public int respuesta { get; set; }
            public string descripcion_respuesta { get; set; }
        }

        public class requestEliminarCliente
        {
            public int Nit { get; set; }
        }
    }
}