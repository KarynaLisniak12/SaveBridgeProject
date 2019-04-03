using System;
using System.Collections.Generic;
using System.Linq;
using SaveBridge.DataAccess.EF;
using SaveBridge.DataAccess.Repositories.Interfaces;
using SaveBridge.Entities;

namespace SaveBridge.DataAccess.Repositories
{
    public class CityRepository : BaseRepository<City>, ICityRepository
    {
        private readonly SaveBridgeContext _dbContext;

        public CityRepository(SaveBridgeContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<City> GetByCountryId(Guid id)
        {
            var cities = _dbContext.Cities.Where(item => item.CountryId == id);
            return cities;
        }
    }
}