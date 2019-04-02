using SaveBridge.DataAccess.EF;
using SaveBridge.DataAccess.Repositories.Interfaces;
using SaveBridge.Entities;

namespace SaveBridge.DataAccess.Repositories
{
    public class CountryRepository : BaseRepository<Country>, ICountryRepository
    {
        public CountryRepository(SaveBridgeContext dbContext) : base(dbContext)
        {

        }
    }
}