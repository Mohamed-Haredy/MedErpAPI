using Microsoft.EntityFrameworkCore;
using MedErp.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedErp.Infrastructure.EntitiesConfig
{
    public class AppointmentTypeConfig : IEntityTypeConfiguration<AppointmentType>
    {
        public void Configure(EntityTypeBuilder<AppointmentType> builder)
        {
            builder.ToTable("AppointmentTypes");
            builder.HasKey(o => o.Id);
            builder.HasData(BuildSeedData());
        }
        private List<AppointmentType> BuildSeedData()
        {
            return new List<AppointmentType>()
            {
                new AppointmentType() { Id = 1, TypeName = "Admission" },
                new AppointmentType() { Id = 2, TypeName = "Consultation" },
                new AppointmentType() { Id = 3, TypeName = "Consultation Gynéco" },
                new AppointmentType() { Id = 4, TypeName = "Consultation MG" },
                new AppointmentType() { Id = 5, TypeName = "Consultation Rhumato" },
                new AppointmentType() { Id = 6, TypeName = "Imaging" },
                new AppointmentType() { Id = 7, TypeName = "Lab" },
                new AppointmentType() { Id = 8, TypeName = "Pharmacy" },
                new AppointmentType() { Id = 9, TypeName = "Testing" }
            };
        }
    }
}
