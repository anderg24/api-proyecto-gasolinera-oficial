using System;

namespace api_proyecto_gasolinera.Models.Abasto
{
    public class csEstructuraAbasto
    {
        public class requestAbasto
        {
            public string idAbasto { get; set; }
            public int idBomba { get; set; }
            public string nombre_proveedor { get; set; } // Cambio de idTipo_de_gasolina a nombre_proveedor
            public double cantidad_galones { get; set; } // Cambio de Litros a cantidad_galones
            public double precio_por_m3 { get; set; } // Nuevo campo precio_por_m3
            public double costo_total { get; set; } // Nuevo campo costo_total
        }

        public class responseAbasto
        {
            public int respuesta { get; set; }
            public string descripcion_respuesta { get; set; }
        }

        public class requestEliminarAbasto
        {
            public string idAbasto { get; set; }
        }
    }
}
