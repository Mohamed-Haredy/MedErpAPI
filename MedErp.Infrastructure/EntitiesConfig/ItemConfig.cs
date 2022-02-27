using Microsoft.EntityFrameworkCore;
using MedErp.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedErp.Infrastructure.EntitiesConfig
{
    public class ItemConfig : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("Items");
            builder.HasKey(o => o.Id);
             
        }

        
    }
}
