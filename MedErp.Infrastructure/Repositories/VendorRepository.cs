using MedErp.Domain.Entities;

namespace MedErp.Infrastructure.Repositories
{
    public class VendorRepository : RepositoryBase<Vendor>, IVendorRepository
    {
        public VendorRepository(MedErpDBContext dbContext) : base(dbContext)
        {
        }
    }
}
