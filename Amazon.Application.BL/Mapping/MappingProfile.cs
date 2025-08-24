using Amazon.DL.Entites;
using AutoMapper;

namespace Amazon.Application.BL.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();

        }
    }
}
