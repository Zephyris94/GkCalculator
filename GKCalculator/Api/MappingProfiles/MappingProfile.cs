using AutoMapper;
using Model.DataTransfer;
using Model.Domain;

namespace Api.MappingProfiles
{
    public class MappingProfile : Profile
    {
        public void AddMapping()
        {
            CreateMap<LineagePathFindingRequest, LineagePathFindingModel>().ReverseMap();
            CreateMap<PathModelResponse, PathModel>().ReverseMap();
        }
    }
}
