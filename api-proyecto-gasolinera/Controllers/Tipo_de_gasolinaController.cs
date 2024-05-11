using api_proyecto_gasolinera.Models.Tipo_de_gasolina;
using api_proyecto_gasolinera.Models.Empleado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using static api_proyecto_gasolinera.Models.Tipo_de_gasolina.csEstructuraTipo_de_gasolina;

namespace api_proyecto_gasolinera.Controllers
{
    public class Tipo_de_gasolinaController : ApiController
    {
        [HttpPost]
        [Route("rest/api/insertarTipo_de_gasolina")]
        public IHttpActionResult insertarEmpleado(requestTipo_de_gasolina model)
        {
            return Ok(new csTipo_de_gasolina().insertarTipo_de_gasolina(model.idtipogasolina, model.descripcion));
        }

        [HttpPost]
        [Route("rest/api/actualizarTipo_de_gasolina")]
        public IHttpActionResult actualizarBomba(requestTipo_de_gasolina model)
        {
            return Ok(new csTipo_de_gasolina().actualizarTipo_de_gasolina(model.idtipogasolina, model.descripcion));
        }

        [HttpPost]
        [Route("rest/api/eliminarTipo_de_gasolina")]
        public IHttpActionResult eliminarBomba(requestEliminarTipo_de_gasolina model)
        {
            return Ok(new csTipo_de_gasolina().eliminarTipo_de_gasolina(model.idtipogasolina));
        }

        [HttpGet]
        [Route("rest/api/listarTipo_de_gasolina")]
        public IHttpActionResult listarTipo_de_gasolina()
        {
            return Ok(new csTipo_de_gasolina().listarTipo_de_gasolina());
        }

        [HttpGet]
        [Route("rest/api/ListarTipo_de_gasolinaXid")]
        public IHttpActionResult listarTipo_de_gasolinaXid(int idtipogasolina)
        {
            return Ok(new csTipo_de_gasolina().listarTipo_de_gasolinaXid(idtipogasolina));
        }
    }
}