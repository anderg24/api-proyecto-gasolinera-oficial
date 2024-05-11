using api_proyecto_gasolinera.Models.Abasto;
using System.Web.Http;
using static api_proyecto_gasolinera.Models.Abasto.csEstructuraAbasto;

namespace api_proyecto_gasolinera.Controllers
{
    public class AbastoController : ApiController
    {
        [HttpPost]
        [Route("rest/api/insertarAbasto")]
        public IHttpActionResult InsertarAbasto(requestAbasto model)
        {
            return Ok(new csAbasto().InsertarAbasto(model.idAbasto, model.idBomba, model.nombre_proveedor, model.cantidad_galones, model.precio_por_m3, model.costo_total));
        }

        [HttpPost]
        [Route("rest/api/actualizarAbasto")]
        public IHttpActionResult ActualizarAbasto(requestAbasto model)
        {
            return Ok(new csAbasto().ActualizarAbasto(model.idAbasto, model.idBomba, model.nombre_proveedor, model.cantidad_galones, model.precio_por_m3, model.costo_total));
        }

        [HttpPost]
        [Route("rest/api/eliminarAbasto")]
        public IHttpActionResult EliminarAbasto(requestEliminarAbasto model)
        {
            return Ok(new csAbasto().EliminarAbasto(model.idAbasto));
        }

        [HttpGet]
        [Route("rest/api/listarAbasto")]
        public IHttpActionResult ListarAbasto()
        {
            return Ok(new csAbasto().ListarAbasto());
        }

        [HttpGet]
        [Route("rest/api/listarAbastoXid")]
        public IHttpActionResult ListarAbastoXid(string idAbasto)
        {
            return Ok(new csAbasto().ListarAbastoXid(idAbasto));
        }
    }
}
