using MedErp.Domain.Entities;

namespace MedErp.Infrastructure.Repositories
{
    public class AdmittedPatientRepository : RepositoryBase<AdmittedPatient>, IAdmittedPatientRepository
    {
        public AdmittedPatientRepository(MedErpDBContext dbContext) : base(dbContext)
        {
        }
    }
}
