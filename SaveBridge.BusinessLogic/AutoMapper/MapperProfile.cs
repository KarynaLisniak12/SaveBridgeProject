using AutoMapper;
using SaveBridge.Entities;
using SaveBridge.ViewModels.BuildingConstruction;

namespace SaveBridge.BusinessLogic.AutoMapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<CreateBuildingViewModel, BuildingConstruction>();
        }
    }
}