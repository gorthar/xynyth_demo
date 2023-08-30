using AutoMapper;

namespace XynythService;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Quote, QuotesDTOs>()
            .IncludeMembers(src => src.Product);
        CreateMap<Product, QuotesDTOs>();
        CreateMap<CreateQuoteDTO, Quote>()
            .ForMember(dest => dest.Product, opt => opt.MapFrom(src => src));
        CreateMap<CreateQuoteDTO, Product>();

    }
}
