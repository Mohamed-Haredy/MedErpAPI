using Microsoft.EntityFrameworkCore;
using MedErp.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedErp.Infrastructure.EntitiesConfig
{
    public class AdmittedPatientConfig : IEntityTypeConfiguration<AdmittedPatient>
    {
        public void Configure(EntityTypeBuilder<AdmittedPatient> builder)
        {
            builder.ToTable("AdmittedPatients");
            builder.HasKey(o => o.Id);  
        } 
    }
}
