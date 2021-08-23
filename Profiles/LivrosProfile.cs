using DrCashApp.Models;
using DrCashApp.Dtos;
using AutoMapper;

namespace DrCashApp.Profiles
{
    public class LivrosProfile : Profile
    {
        public LivrosProfile()
        {
            //Source -> Target
            CreateMap<Livro, LivroReadDto>();
            CreateMap<LivroCreateDto, Livro>();
            CreateMap<LivroUpdateDto, Livro>();
            CreateMap<Livro, LivroUpdateDto>();

        }
    }
}