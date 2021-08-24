using DrCashApp.Models;
using DrCashApp.Dtos;
using AutoMapper;

namespace DrCashApp.Profiles
{
    public class GenerosProfile : Profile
    {
        public GenerosProfile()
        {
            //Source -> Target
            CreateMap<Genero, GeneroReadDto>();
            CreateMap<GeneroCreateDto, Genero>();
            CreateMap<GeneroUpdateDto, Genero>();
            CreateMap<Genero, GeneroUpdateDto>();

        }
    }
}