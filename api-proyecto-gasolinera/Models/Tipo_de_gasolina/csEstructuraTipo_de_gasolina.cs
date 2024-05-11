using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api_proyecto_gasolinera.Models.Tipo_de_gasolina
{
    public class csEstructuraTipo_de_gasolina
    {
        public class requestTipo_de_gasolina
        {
            public int idtipogasolina { get; set; }
            public string descripcion { get; set; }

        }

        public class responseTipo_de_gasolina
        {
            public int respuesta { get; set; }
            public string descripcion_respuesta { get; set; }
        }
        public class requestEliminarTipo_de_gasolina
        {
            public int idtipogasolina { get; set; }
        }
    }
}