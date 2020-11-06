using System;
using System.Collections.Generic;
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

            var pedidoRetorno = _mapper.Map<ProdutoDto>(produto);

            return Ok(pedidoRetorno);
        }
        
        [HttpPost]

        public async Task<IActionResult> Post(ProdutoDto produtoAdicionar)
        {
            try
            {
                var produto = _mapper.Map<Produto>(produtoAdicionar);

                List<CategoriaProduto> categoriaAdicionar = new List<CategoriaProduto>();

                foreach (var categoria in produtoAdicionar.Categoria)
                {
                    var addCategoria = new CategoriaProduto
                    {
                        CategoriaId = categoria.Id
                    };
                    categoriaAdicionar.Add(addCategoria);
                }

                produto.CategoriaProduto.Add(categoriaAdicionar);

                var produtoSalvar = await _service.AddProduto(produto);

                if (!produtoSalvar)
                {
                    return BadRequest("Erro ao tentar salvar o produto");
                }
            
                return Ok("Pedido Salvo com suceso!");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            
        }
    }
}