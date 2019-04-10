using AutoMapper;
using SaveBridge.Entities;
using SaveBridge.ViewModels.Account;
using SaveBridge.ViewModels.Breakdown;
using SaveBridge.ViewModels.BuildingConstruction;
using SaveBridge.ViewModels.BuildingConstructionType;
using SaveBridge.ViewModels.City;
using SaveBridge.ViewModels.Country;
using SaveBridge.ViewModels.Pressure;
using SaveBridge.ViewModels.Renovation;
using SaveBridge.ViewModels.Vibration;
using System;

namespace SaveBridge.BusinessLogic.AutoMapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            #region " Account... "

            CreateMap<SignInViewModel, ApplicationUser>();
            CreateMap<SignUpViewModel, ApplicationUser>();

            #endregion

            #region " BuildingConstructionType... "

            CreateMap<BuildingTypeViewModel, BuildingConstructionType>().ReverseMap();
            CreateMap<CreateBuildingTypeViewModel, BuildingConstructionType>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid()));
            CreateMap<UpdateBuildingTypeViewModel, BuildingConstructionType>();

            #endregion

            #region " BuildingConstruction... "
            
            CreateMap<BuildingViewModel, BuildingConstruction>().ReverseMap();
            CreateMap<CreateBuildingViewModel, BuildingConstruction>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid()));
            CreateMap<UpdateBuildingViewModel, BuildingConstruction>();

            #endregion

            #region " Breakdown... "

            CreateMap<BreakdownViewModel, Breakdown>().ReverseMap();
            CreateMap<CreateBreakdownViewModel, Breakdown>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid()));
            CreateMap<UpdateBreakdownViewModel, Breakdown>();

            #endregion

            #region " City... "

            CreateMap<City, CityViewModel>()
                .ForMember(dest => dest.CountryTitle, opt => opt.MapFrom(src => src.Country.Title))
                .ReverseMap();
            CreateMap<CreateCityViewModel, City>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid()));

            #endregion

            #region " Country... "

            CreateMap<CountryViewModel, Country>().ReverseMap();
            CreateMap<CreateCountryViewModel, Country>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid()));

            #endregion

            #region " Pressure... "

            CreateMap<PressureViewModel, Pressure>().ReverseMap();
            CreateMap<CreatePressureViewModel, Pressure>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid()));

            #endregion

            #region " Renovation... "s

            CreateMap<RenovationViewModel, Renovation>().ReverseMap();
            CreateMap<CreateRenovationViewModel, Renovation>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid()));
            CreateMap<UpdateRenovationViewModel, Renovation>();

            #endregion

            #region " Vibration... "

            CreateMap<VibrationViewModel, Vibration>().ReverseMap();
            CreateMap<CreateVibrationViewModel, Vibration>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid()));

            #endregion
        }
    }
}