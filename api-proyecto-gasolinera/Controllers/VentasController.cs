using System;
using System.Web.Http;
using api_proyecto_gasolinera.Models.Cliente;
using api_proyecto_gasolinera.Models.Ventas;
using static api_proyecto_gasolinera.Models.Ventas.CSEstructuraVentas;

namespace api_proyecto_gasolinera.Controllers
{
    public class VentasController : ApiController
    {
        [HttpPost]
        [Route("rest/api/insertarVenta")]
        public IHttpActionResult InsertarVenta(requestventas model)
        {
            var ventas = new csVenta();
            var respuesta = ventas.InsertarVenta(model.idventa, model.nit, model.idempleado, model.idformapago, model.idtipogasolina, model.idbomba, model.fecha, model.total_venta);
            return Ok(respuesta);
        }

        [HttpPost]
        [Route("rest/api/actualizarVenta")]
        public IHttpActionResult ActualizarVenta(requestventas model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            var ventas = new csVenta();
            responseVenta respuesta = ventas.ActualizarVenta(model.idventa, model.nit, model.idempleado, model.idformapago, model.idtipogasolina, model.idbomba, model.fecha, model.total_venta);

            return Ok(respuesta);
        }

        [HttpPost]
        [Route("rest/api/eliminarVenta")]
        public IHttpActionResult EliminarVenta(requestEliminarVenta model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            var ventas = new csVenta();
            var respuesta = ventas.EliminarVenta(model.idVenta);

            return Ok(respuesta);
        }

        [HttpGet]
        [Route("rest/api/listarVenta")]
        public IHttpActionResult ListarVenta()
        {
            var ventas = new csVenta();
            var respuesta = ventas.ListarVenta();

            return Ok(respuesta);
        }

        [HttpGet]
        [Route("rest/api/listarVentaXid")]
        public IHttpActionResult ListarVentaXid(string idVenta)
        {
            var ventas = new csVenta();
            var respuesta = ventas.ListarVentaXId(idVenta);

            return Ok(respuesta);
        }
    }
}
