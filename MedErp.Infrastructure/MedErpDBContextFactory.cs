using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MedErp.Infrastructure
{
    public class MedErpDBContextFactory : IDesignTimeDbContextFactory<MedErpDBContext>
    {
        public MedErpDBContext CreateDbContext(string[] args)
        { 
            var connectionString = "Data Source=localhost;Initial Catalog=MedicalERP;Persist Security Info=True;User ID=sa;Password=sa"; 
            return new MedErpDBContext(connectionString);
        }
    }
}
