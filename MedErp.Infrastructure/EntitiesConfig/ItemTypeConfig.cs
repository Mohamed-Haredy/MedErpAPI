using Microsoft.EntityFrameworkCore;
using MedErp.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedErp.Infrastructure.EntitiesConfig
{
    public class ItemTypeConfig : IEntityTypeConfiguration<ItemType>
    {
        public void Configure(EntityTypeBuilder<ItemType> builder)
        {
            builder.ToTable("ItemTypes");
            builder.HasKey(o => o.Id);
            builder.HasData(BuildSeedData());
        }
        private List<ItemType> BuildSeedData()
        {
            return new List<ItemType>()
            {
                new ItemType() { Id = 1, TypeName = "Clothing" },
                new ItemType() { Id = 2, TypeName = "Equipment" },
                new ItemType() { Id = 3, TypeName = "Medication" }
            };
        }
    }
}
