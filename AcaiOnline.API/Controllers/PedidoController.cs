using System.Threading.Tasks;
using AcaiOnline.Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace AcaiOnline.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoService _service;

        public PedidoController(IPedidoService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetValue()
        {
            var pedidos = await _service.GetAllPedidos();
            return Ok(pedidos);
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetValue(int id)
        {
            var pedido = await _service.GetPedidoById(id);

            if (pedido == null)
            {
                return NotFound("Pedido não encontrado");
            }
            return Ok(pedido);
        }
    }
}