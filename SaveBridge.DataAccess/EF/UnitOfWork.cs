using SaveBridge.DataAccess.EF.Interfaces;
using SaveBridge.DataAccess.Repositories.Interfaces;

namespace SaveBridge.DataAccess.EF
{
    public class UnitOfWork : IUnitOfWorks
    {
        private readonly SaveBridgeContext _dbContext;

        public IBuildingConstructionRepository BuildingConstructionRepository { get; set; }

        public IBuildingConstructionTypeRepository BuildingConstructionTypeRepository { get; set; }

        public IPressureRepository PressureRepository { get; set; }

        public IVibrationRepository VibrationRepository { get; set; }

        public ICityRepository CityRepository { get; set; }

        public ICountryRepository CountryRepository { get; set; }

        public IBreakdownRepository BreakdownRepository { get; set; }

        public IRenovationRepository RenovationRepository { get; set; }
        
        public UnitOfWork(
            SaveBridgeContext dbContext, 
            IBuildingConstructionRepository buildingConstructionRepository, 
            IBuildingConstructionTypeRepository buildingConstructionTypeRepository, 
            IPressureRepository pressureRepository, 
            IVibrationRepository vibrationRepository, 
            ICityRepository cityRepository, 
            ICountryRepository countryRepository, 
            IBreakdownRepository breakdownRepository, 
            IRenovationRepository renovationRepository)
        {
            _dbContext = dbContext;
            BuildingConstructionRepository = buildingConstructionRepository;
            BuildingConstructionTypeRepository = buildingConstructionTypeRepository;
            PressureRepository = pressureRepository;
            VibrationRepository = vibrationRepository;
            CityRepository = cityRepository;
            CountryRepository = countryRepository;
            BreakdownRepository = breakdownRepository;
            RenovationRepository = renovationRepository;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}