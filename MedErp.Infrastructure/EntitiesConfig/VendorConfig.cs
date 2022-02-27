using Microsoft.EntityFrameworkCore;
using MedErp.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedErp.Infrastructure.EntitiesConfig
{
    public class VendorConfig : IEntityTypeConfiguration<Vendor>
    {
        public void Configure(EntityTypeBuilder<Vendor> builder)
        {
            builder.ToTable("Vendors");
            builder.HasKey(o => o.Id);  

        } 
    }
}
