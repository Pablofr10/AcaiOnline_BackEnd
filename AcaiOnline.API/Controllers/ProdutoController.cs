using System.Threading.Tasks;
using AcaiOnline.Core.Interfaces.Services;
using AcaiOnline.Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace AcaiOnline.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _service;

        public ProdutoController(IProdutoService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var pedidos = await _service.GetAllProdutos();
            return Ok(pedidos);
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetById(int id)
        {
            var pedido = await _service.GetProdutoById(id);

            if (pedido == null)
            {
                return NotFound("Pedido não encontrado");
            }
            return Ok(pedido);
        }
        
        [HttpPost]

        public async Task<IActionResult> Post(Produto produto)
        {
            var produtoSalvar = await _service.AddProduto(produto);

            if (!produtoSalvar)
            {
                return BadRequest("Erro ao tentar salvar o produto");
            }

            return Ok("Pedido Salvo com suceso!");
        }
    }
}