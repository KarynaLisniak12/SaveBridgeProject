using System;
using AutoMapper;
using SaveBridge.Entities;
using SaveBridge.ViewModels.BuildingConstruction;
using SaveBridge.ViewModels.BuildingConstructionType;

namespace SaveBridge.BusinessLogic.AutoMapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            #region MyRegion

            CreateMap<CreateBuildingTypeViewModel, BuildingConstructionType>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid()));
            CreateMap<UpdateBuildingTypeViewModel, BuildingConstructionType>();
            CreateMap<BuildingConstructionType, BuildingTypeViewModel>();

            #endregion

            CreateMap<CreateBuildingViewModel, BuildingConstruction>();
        }
    }
}