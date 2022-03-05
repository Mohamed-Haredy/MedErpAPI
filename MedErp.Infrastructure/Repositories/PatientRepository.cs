using MedErp.Domain.Entities;

namespace MedErp.Infrastructure.Repositories
{
    public class PatientRepository : RepositoryBase<Patient>, IPatientRepository
    {
        public PatientRepository(MedErpDBContext dbContext) : base(dbContext)
        {
        }
    }
}
