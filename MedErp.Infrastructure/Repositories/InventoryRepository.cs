using MedErp.Domain.Entities;

namespace MedErp.Infrastructure.Repositories
{
    public class InventoryRepository : RepositoryBase<Inventory>, IInventoryRepository
    {
        public InventoryRepository(MedErpDBContext dbContext) : base(dbContext)
        {
        }
    }
}
