using api_proyecto_gasolinera.Models.Empleado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using static api_proyecto_gasolinera.Models.Empleado.csEstructuraEmpleado;

namespace api_proyecto_gasolinera.Controllers
{
    public class EmpleadoController : ApiController
    {
        [HttpPost]
        [Route("rest/api/insertarEmpleado")]
        public IHttpActionResult insertarEmpleado(requestEmpleado model)
        {
            return Ok(new csEmpleado().insertarEmpleado(model.idempleado, model.nombre_empleado,model.direccion,model.telefono, model.correo_electronico, model.puesto));
        }

        [HttpPost]
        [Route("rest/api/actualizarEmpleado")]
        public IHttpActionResult actualizarEmpleado(requestEmpleado model)
        {
            return Ok(new csEmpleado().actualizarEmpleado(model.idempleado, model.nombre_empleado, model.direccion, model.telefono, model.correo_electronico, model.puesto));
        }

        [HttpPost]
        [Route("rest/api/eliminarEmpleado")]
        public IHttpActionResult eliminarEmpleado(requestEliminarArticulo model)
        {
            return Ok(new csEmpleado().eliminarEmpleado(model.idempleado));
        }

        [HttpGet]
        [Route("rest/api/listarEmpleado")]
        public IHttpActionResult listarEmpleado()
        {
            return Ok(new csEmpleado().listarEmpleado());
        }

        [HttpGet]
        [Route("rest/api/listarEmpleadoXid")]
        public IHttpActionResult listarEmpleadoXid(int idempleado)
        {
            return Ok(new csEmpleado().listarEmpleadoXid(idempleado));
        }
    }
}