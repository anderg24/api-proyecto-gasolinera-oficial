using api_proyecto_gasolinera.Models.Bomba;
using api_proyecto_gasolinera.Models.Empleado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using static api_proyecto_gasolinera.Models.Bomba.csEstructuraBomba;

namespace api_proyecto_gasolinera.Controllers
{
    public class BombaController : ApiController
    {
        [HttpPost]
        [Route("rest/api/insertarBomba")]
        public IHttpActionResult insertarEmpleado(requestBomba model)
        {
            return Ok(new csBomba().insertarBomba(model.idbomba,model.idtipogasolina, model.m_gasolina,model.precio_galon));
        }

        [HttpPost]
        [Route("rest/api/actualizarBomba")]
        public IHttpActionResult actualizarBomba(requestBomba model)
        {
            return Ok(new csBomba().actualizarBomba(model.idbomba, model.idtipogasolina, model.m_gasolina, model.precio_galon));
        }

        [HttpPost]
        [Route("rest/api/eliminarBomba")]
        public IHttpActionResult eliminarBomba(requestEliminarBomba model)
        {
            return Ok(new csBomba().eliminarBomba(model.idbomba));
        }

        [HttpGet]
        [Route("rest/api/listarBomba")]
        public IHttpActionResult listarBomba()
        {
            return Ok(new csBomba().listarBomba());
        }

        [HttpGet]
        [Route("rest/api/ListarBombaXid")]
        public IHttpActionResult listarBombaXid(int idBomba)
        {
            return Ok(new csBomba().listarBombaXid(idBomba));
        }
    }
}