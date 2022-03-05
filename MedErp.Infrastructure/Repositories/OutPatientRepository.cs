using MedErp.Domain.Entities;

namespace MedErp.Infrastructure.Repositories
{
    public class OutPatientRepository : RepositoryBase<OutPatient>, IOutPatientRepository
    {
        public OutPatientRepository(MedErpDBContext dbContext) : base(dbContext)
        {
        }
    }
}
