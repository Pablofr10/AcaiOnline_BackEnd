using System.Linq;
using AcaiOnline.Core.Dtos;
using AcaiOnline.Core.Entities;
using AcaiOnline.Entities.Models;
using AutoMapper;

namespace AcaiOnline.Core.Helpers
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Produto, ProdutoDto > ().ForMember(dest => dest.Categoria, opt => 
                opt.MapFrom(src => src.CategoriaProduto.Select(c => c.Categoria)));

            CreateMap<Categoria, CategoriaDto>()
                .ForMember(dest => dest.Produto, opt =>
                    opt.MapFrom(src => src.CategoriaProdutos.Select(r => new ProdutoDto { Id = r.ProdutoId }).ToList()));

            CreateMap<CategoriaDto, Categoria>()
                .ForMember(dest => dest.CategoriaProdutos, opt =>
                    opt.MapFrom(src => src.Produto.Select(r => new CategoriaProduto { ProdutoId = r.Id, CategoriaId =  src.Id}).ToList()));

        }
    }
}