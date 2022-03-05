using MedErp.Domain.Entities;

namespace MedErp.Infrastructure.Repositories
{
    public class BloodTypeRepository : RepositoryBase<BloodType>, IBloodTypeRepository
    {
        public BloodTypeRepository(MedErpDBContext dbContext) : base(dbContext)
        {
        }
    }
}
