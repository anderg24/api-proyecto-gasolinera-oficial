using api_proyecto_gasolinera.Models.Bomba;
using api_proyecto_gasolinera.Models.Empleado;
using api_proyecto_gasolinera.Models.Forma_de_pago;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using static api_proyecto_gasolinera.Models.Forma_de_pago.csEstructuraForma_de_pago;
using static api_proyecto_gasolinera.Models.Forma_de_pago.csForma_de_pago;


namespace api_proyecto_gasolinera.Controllers
{
    public class Forma_de_pagoController : ApiController
    {
        [HttpPost]
        [Route("rest/api/insertarForma_de_pago")]
        public IHttpActionResult insertarEstructuraForma_de_pago(requestForma_de_pago model)
        {
            return Ok(new csForma_de_pago().insertarForma_de_pago(model.idformapago, model.descripcion));
        }

        [HttpPost]
        [Route("rest/api/actualizarForma_de_pago")]
        public IHttpActionResult actualizarForma_de_pago(requestForma_de_pago model)
        {
            return Ok(new csForma_de_pago().actualizarForma_de_pago(model.idformapago, model.descripcion));
        }

        [HttpPost]
        [Route("rest/api/eliminarForma_de_pago")]
        public IHttpActionResult eliminarEstructuraForma_de_pago(requestEliminarForma_de_pago model)
        {
            return Ok(new csForma_de_pago().eliminarForma_de_pago(model.idformapago));
        }

        [HttpGet]
        [Route("rest/api/listarForma_de_pago")]
        public IHttpActionResult listarForma_de_pago()
        {
            return Ok(new csForma_de_pago().listarForma_de_pago());
        }

        [HttpGet]
        [Route("rest/api/ListarForma_de_pagoXid")]
        public IHttpActionResult listarForma_de_pagoXid(int idformapago)
        {
            return Ok(new csForma_de_pago().listarForma_de_pagoXid(idformapago));
        }
    }
}