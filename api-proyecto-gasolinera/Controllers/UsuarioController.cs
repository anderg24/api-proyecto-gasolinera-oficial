

using api_proyecto_gasolinera.Models.Empleado;
using api_proyecto_gasolinera.Models.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

using static api_proyecto_gasolinera.Models.Usuario.csEstructuraUsuario;

namespace api_proyecto_gasolinera.Controllers
{
    public class UsuarioController : ApiController
    {
        [HttpPost]
        [Route("rest/api/insertarUsuario")]
        public IHttpActionResult insertarUsuario(requestUsuario model)
        {
            return Ok(new csUsuario().insertarUsuario(model.idusuario, model.idempleado, model.contraseña, model.alias, model.pasatiempos, model.correo_alternativo));
        }

        [HttpPost]
        [Route("rest/api/actualizarUsuario")]
        public IHttpActionResult actualizarUsuario(requestUsuario model)
        {
            return Ok(new csUsuario().actualizarUsuario(model.idusuario, model.idempleado, model.contraseña, model.alias, model.pasatiempos, model.correo_alternativo));
        }

        [HttpPost]
        [Route("rest/api/eliminarUsuario")]
        public IHttpActionResult eliminarUsuario(requestEliminarUsuario model)
        {
            return Ok(new csUsuario().eliminarUsuario(model.idUsuario));
        }

        [HttpGet]
        [Route("rest/api/listarUsuario")]
        public IHttpActionResult listarUsuario()
        {
            return Ok(new csUsuario().ListarUsuario());
        }

        [HttpGet]
        [Route("rest/api/listarUsuarioXid")]
        public IHttpActionResult listarUsuarioXid(int idusuario)
        {
            return Ok(new csUsuario().ListarUsuarioXid(idusuario));
        }
    }
}