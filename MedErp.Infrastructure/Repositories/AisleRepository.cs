using MedErp.Domain.Entities;

namespace MedErp.Infrastructure.Repositories
{
    public class AisleRepository : RepositoryBase<Aisle>, IAisleRepository
    {
        public AisleRepository(MedErpDBContext dbContext) : base(dbContext)
        {
        }
    }
}
