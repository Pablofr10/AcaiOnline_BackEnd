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
                opt.MapFrom(src => src.CategoriaProduto.Select(c => c.Categoria))).ReverseMap();

            CreateMap<Categoria, CategoriaDto>().ReverseMap();

        }
    }
}