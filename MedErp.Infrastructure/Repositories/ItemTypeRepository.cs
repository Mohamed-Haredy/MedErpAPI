using MedErp.Domain.Entities;

namespace MedErp.Infrastructure.Repositories
{
    public class ItemTypeRepository : RepositoryBase<ItemType>, IItemTypeRepository
    {
        public ItemTypeRepository(MedErpDBContext dbContext) : base(dbContext)
        {
        }
    }
}
