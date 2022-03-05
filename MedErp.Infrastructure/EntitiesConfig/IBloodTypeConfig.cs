using Microsoft.EntityFrameworkCore;
using MedErp.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedErp.Infrastructure.EntitiesConfig
{
    public class IBloodTypeConfig : IEntityTypeConfiguration<BloodType>
    {
        public void Configure(EntityTypeBuilder<BloodType> builder)
        {
            builder.ToTable("IBloodTypes");
            builder.HasKey(o => o.Id);
            builder.HasData(BuildSeedData());
        }
        private List<BloodType> BuildSeedData()
        {
            return new List<BloodType>()
            {
                new BloodType() { Id = 1, TypeName = "A+" },
                new BloodType() { Id = 2, TypeName = "A-" },
                new BloodType() { Id = 3, TypeName = "AB+" },
                new BloodType() { Id = 4, TypeName = "AB-" },
                new BloodType() { Id = 5, TypeName = "B+" },
                new BloodType() { Id = 6, TypeName = "B-" },
                new BloodType() { Id = 7, TypeName = "O+" },
                new BloodType() { Id = 8, TypeName = "O-" }
            };
        }
    }
}
