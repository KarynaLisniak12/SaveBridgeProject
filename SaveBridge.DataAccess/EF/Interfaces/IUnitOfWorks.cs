using SaveBridge.DataAccess.Repositories.Interfaces;

namespace SaveBridge.DataAccess.EF.Interfaces
{
    public interface IUnitOfWorks
    {
        IBuildingConstructionRepository BuildingConstructionRepository { get; set; }

        IBuildingConstructionTypeRepository BuildingConstructionTypeRepository { get; set; }

        IPressureRepository PressureRepository { get; set; }

        IVibrationRepository VibrationRepository { get; set; }

        ICityRepository CityRepository { get; set; }

        ICountryRepository CountryRepository { get; set; }

        IBreakdownRepository BreakdownRepository { get; set; }

        IRenovationRepository RenovationRepository { get; set; }

        void Save();
    }
}