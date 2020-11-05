using System.Threading.Tasks;
using AcaiOnline.Core.Dtos;
using AcaiOnline.Core.Entities;
using AcaiOnline.Core.Interfaces.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AcaiOnline.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _service;
        private readonly IMapper _mapper;

        public ProdutoController(IProdutoService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var produtos = await _service.GetAllProdutos();
            return Ok(produtos);
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetById(int id)
        {
            Produto produto = await _service.GetProdutoById(id);

            if (produto == null)
            {
                return NotFound("Pedido não encontrado");
            }

            return Ok(produto);
        }
        
        [HttpPost]

        public async Task<IActionResult> Post(Produto produtoAdicionar)
        {
            var produtoSalvar = await _service.AddProduto(produtoAdicionar);

            if (!produtoSalvar)
            {
                return BadRequest("Erro ao tentar salvar o produto");
            }

            return Ok("Pedido Salvo com suceso!");
        }
    }
}