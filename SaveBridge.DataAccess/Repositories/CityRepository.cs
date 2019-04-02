using SaveBridge.DataAccess.EF;
using SaveBridge.DataAccess.Repositories.Interfaces;
using SaveBridge.Entities;

namespace SaveBridge.DataAccess.Repositories
{
    public class CityRepository : BaseRepository<City>, ICityRepository
    {
        public CityRepository(SaveBridgeContext dbContext) : base(dbContext)
        {

        }
    }
}