using Microsoft.EntityFrameworkCore;
using MedErp.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedErp.Infrastructure.EntitiesConfig
{
    public class ReligionConfig : IEntityTypeConfiguration<Religion>
    {
        public void Configure(EntityTypeBuilder<Religion> builder)
        {
            builder.ToTable("Religions");
            builder.HasKey(o => o.Id);
            builder.HasData(BuildSeedData());
        }
        private List<Religion> BuildSeedData()
        {
            return new List<Religion>()
            {
                new Religion() { Id = 1, ReligionName = "Islam" },
                new Religion() { Id = 2, ReligionName = "Christian" },
                new Religion() { Id = 3, ReligionName = "Jewish" }
                 

            };
        }
    }
}
