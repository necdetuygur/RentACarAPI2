using AutoMapper;
using RentACar2.API.DTOs;
using RentACar2.Core.Models;

namespace RentACar2.API.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Araba, ArabaDto>();
            CreateMap<ArabaDto, Araba>();

            CreateMap<Alici, AliciDto>();
            CreateMap<AliciDto, Alici>();

            CreateMap<Firma, FirmaDto>();
            CreateMap<FirmaDto, Firma>();

            CreateMap<Kiralama, KiralamaDto>();
            CreateMap<KiralamaDto, Kiralama>();
        }
    }
}
