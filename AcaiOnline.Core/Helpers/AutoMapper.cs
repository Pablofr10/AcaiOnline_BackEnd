using System.Linq;
using AcaiOnline.Core.Dtos;
using AcaiOnline.Core.Entities;
using AutoMapper;

namespace AcaiOnline.Core.Helpers
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Produto, ProdutoDto>().ForMember(dest => dest.Categoria, opt =>
                    opt.MapFrom(src => src.CategoriaProduto.Select(r => r.Categoria).ToList()))
                .ReverseMap();

            CreateMap<Categoria, CategoriaDto>().ForMember(dest => dest.Produto, opt =>
                    opt.MapFrom(src => src.CategoriaProdutos.Select(r => r.Produto).ToList()))
                .ReverseMap();

            CreateMap<Pedido, PedidoDto>()
                .ForMember(dest => dest.Produto, opt =>
                    opt.MapFrom(src => src.PedidoProduto.Select(r => new ProdutoDto
                    {
                        Nome = r.Produto.Nome, Id = r.ProdutoId, Descricao = r.Produto.Descricao,
                        ImagemURL = r.Produto.ImagemURL, Quantidade = r.Quantidade,
                        IsDisponivel = r.Produto.IsDisponivel
                    }).ToList()));


        }
    }
}