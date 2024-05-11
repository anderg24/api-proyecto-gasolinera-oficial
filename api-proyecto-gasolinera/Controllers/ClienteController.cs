using api_proyecto_gasolinera.Models.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using static api_proyecto_gasolinera.Models.Cliente.csEstructuraCliente;


namespace api_proyecto_gasolinera.Controllers
{
    public class ClienteController : ApiController
    {
        [HttpPost]
        [Route("rest/api/insertarCliente")]
        public IHttpActionResult insertarEmpleado(requestCliente model)
        {
            return Ok(new csCliente().insertarCliente( model.Nit, model.Nombre, model.Vehiculo));
        }

        [HttpPost]
        [Route("rest/api/actualizarCliente")]
        public IHttpActionResult actualizarCliente(requestCliente model)
        {
            return Ok(new csCliente().actualizarCliente( model.Nit, model.Nombre, model.Vehiculo));
        }

        [HttpPost]
        [Route("rest/api/eliminarCliente")]
        public IHttpActionResult eliminarCliente(requestEliminarCliente model)
        {
            return Ok(new csCliente().eliminarCliente(model.Nit));
        }

        [HttpGet]
        [Route("rest/api/listarCliente")]
        public IHttpActionResult listarCliente()
        {
            return Ok(new csCliente().listarClientes());
        }

        [HttpGet]
        [Route("rest/api/listarClientePorNit")]
        public IHttpActionResult listarClientePorNit(int Nit)
        {
            return Ok(new csCliente().listarClientePorNit(Nit));
        }
    }
}