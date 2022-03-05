using MedErp.Domain.Entities;

namespace MedErp.Infrastructure.Repositories
{
    public class AppointmentTypeRepository : RepositoryBase<AppointmentType>, IAppointmentTypeRepository
    {
        public AppointmentTypeRepository(MedErpDBContext dbContext) : base(dbContext)
        {
        }
    }
}
