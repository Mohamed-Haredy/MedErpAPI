using MedErp.Domain.Entities;

namespace MedErp.Infrastructure.Repositories
{
    public class ItemRepository : RepositoryBase<Item>, IItemRepository
    {
        public ItemRepository(MedErpDBContext dbContext) : base(dbContext)
        {
        }
    }
}
