using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api_proyecto_gasolinera.Models.Empleado
{
    public class csEstructuraEmpleado
    {
        public class requestEmpleado
        {
            public int idempleado { get; set; }
            public string nombre_empleado { get; set; }
            public string direccion { get; set; }
            public string telefono { get; set; }
            public string correo_electronico { get; set; }
            public string puesto { get; set; }

        }

        public class responseEmpleado
        {
            public int respuesta { get; set; }
            public string descripcion_respuesta { get; set; }
        }
        public class requestEliminarArticulo
        {
            public int idempleado { get; set; }
        }
    }
}