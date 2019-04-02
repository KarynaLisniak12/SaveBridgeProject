using SaveBridge.DataAccess.EF.Interfaces;
using SaveBridge.DataAccess.Repositories.Interfaces;

namespace SaveBridge.DataAccess.EF
{
    public class UnitOfWork : IUnitOfWorks
    {
        private readonly SaveBridgeContext _dbContext;

        public IBuildingConstructionRepository BuildingConstructionRepository { get; set; }

        public UnitOfWork(
            SaveBridgeContext dbContext,
            IBuildingConstructionRepository buidingConstructionRepository)
        {
            _dbContext = dbContext;
            BuildingConstructionRepository = buidingConstructionRepository;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}