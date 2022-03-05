using Microsoft.EntityFrameworkCore;
using MedErp.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedErp.Infrastructure.EntitiesConfig
{
    public class OutPatientConfig : IEntityTypeConfiguration<OutPatient>
    {
        public void Configure(EntityTypeBuilder<OutPatient> builder)
        {
            builder.ToTable("OutPatients");
            builder.HasKey(o => o.Id);  
        } 
    }
}
