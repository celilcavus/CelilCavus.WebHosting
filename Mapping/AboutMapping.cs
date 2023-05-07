using AutoMapper;
using CelilCavus.GreenHosting.Dto.About;
using CelilCavus.GreenHosting.Entitys;

namespace CelilCavus.GreenHosting.Mapping
{
    public class AboutMapping:Profile
    {
        public AboutMapping()
        {
            CreateMap<AboutUs,AboutAddDto>().ReverseMap();
        }
    }
}