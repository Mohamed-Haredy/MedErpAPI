using MedErp.Domain.Entities;

namespace MedErp.Infrastructure.Repositories
{
    public class DoctorRepository : RepositoryBase<Doctor>, IDoctorRepository
    {
        public DoctorRepository(MedErpDBContext dbContext) : base(dbContext)
        {
        }
    }
}
