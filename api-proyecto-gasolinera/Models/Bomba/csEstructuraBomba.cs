using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api_proyecto_gasolinera.Models.Bomba
{
    public class csEstructuraBomba
    {
        public class requestBomba
        {
            public int idbomba { get; set; }
            public int idtipogasolina { get; set; }
            public double m_gasolina { get; set; }
            public double precio_galon { get; set; }

        }

        public class responseBomba
        {
            public int respuesta { get; set; }
            public string descripcion_respuesta { get; set; }
        }
        public class requestEliminarBomba
        {
            public int idbomba { get; set; }
        }
    }
}