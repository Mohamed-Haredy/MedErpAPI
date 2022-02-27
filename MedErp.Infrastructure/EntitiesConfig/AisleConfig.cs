using Microsoft.EntityFrameworkCore;
using MedErp.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedErp.Infrastructure.EntitiesConfig
{
    public class AisleConfig : IEntityTypeConfiguration<Aisle>
    {
        public void Configure(EntityTypeBuilder<Aisle> builder)
        {
            builder.ToTable("Aisles");
            builder.HasKey(o => o.Id);  
        } 
    }
}
