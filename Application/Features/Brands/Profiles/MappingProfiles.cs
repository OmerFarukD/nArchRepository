using Application.Features.Brands.Commands.Create;
using Application.Features.Brands.Queries.GetList;
using AutoMapper;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;

namespace Application.Features.Brands.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Brand, CreatedBrandResponse>().ReverseMap();
        CreateMap<Brand, CreateBrandCommand>().ReverseMap();
        CreateMap<Brand, GetListBrandListItemDto>();
        CreateMap<Paginate<Brand>,GetListResponse<GetListBrandListItemDto>>();
    }
}