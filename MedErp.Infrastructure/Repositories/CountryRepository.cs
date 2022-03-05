using MedErp.Domain.Entities;

namespace MedErp.Infrastructure.Repositories
{
    public class CountryRepository : RepositoryBase<Country>, ICountryRepository
    {
        public CountryRepository(MedErpDBContext dbContext) : base(dbContext)
        {
        }
    }
}
