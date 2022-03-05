using MedErp.Domain.Entities;

namespace MedErp.Infrastructure.Repositories
{
    public class ReligionRepository : RepositoryBase<Religion>, IReligionRepository
    {
        public ReligionRepository(MedErpDBContext dbContext) : base(dbContext)
        {
        }
    }
}
