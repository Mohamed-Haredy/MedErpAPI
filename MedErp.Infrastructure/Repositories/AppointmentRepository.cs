using MedErp.Domain.Entities;

namespace MedErp.Infrastructure.Repositories
{
    public class AppointmentRepository : RepositoryBase<Appointment>, IAppointmentRepository
    {
        public AppointmentRepository(MedErpDBContext dbContext) : base(dbContext)
        {
        }
    }
}
