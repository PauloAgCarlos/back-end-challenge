using DrCashApp.Models;
using DrCashApp.Dtos;
using AutoMapper;

namespace DrCashApp.Profiles
{
    public class AutoresProfile : Profile
    {
        public AutoresProfile()
        {
            //Source -> Target
            CreateMap<Autor, AutorReadDto>();
            CreateMap<AutorCreateDto, Autor>();
            CreateMap<AutorUpdateDto, Autor>();
            CreateMap<Autor, AutorUpdateDto>();

        }
    }
}