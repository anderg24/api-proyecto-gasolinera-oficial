using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api_proyecto_gasolinera.Models.Usuario
{
    public class csEstructuraUsuario
    {
        public class requestUsuario
        {
            public int idusuario { get; set; }
            public int idempleado { get; set; }
            public string contraseña { get; set; }
            public string alias { get; set; }
            public string pasatiempos { get; set; }
            public string correo_alternativo { get; set; }

        }

        public class responseUsuario
        {
            public int respuesta { get; set; }
            public string descripcion_respuesta { get; set; }
        }
        public class requestEliminarUsuario
        {
            public int idUsuario { get; set; }
        }
    }
}