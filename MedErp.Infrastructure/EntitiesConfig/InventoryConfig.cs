using Microsoft.EntityFrameworkCore;
using MedErp.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedErp.Infrastructure.EntitiesConfig
{
    public class InventoryConfig : IEntityTypeConfiguration<Inventory>
    {
        public void Configure(EntityTypeBuilder<Inventory> builder)
        {
            builder.ToTable("Inventories");
            builder.HasKey(o => o.Id);  
        } 
    }
}
