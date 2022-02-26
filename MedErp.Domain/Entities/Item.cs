using MedErp.Domain.Base;

namespace MedErp.Domain.Entities
{
    public class Item : Entity,IAggregateRoot
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int? Quantity { get; set; }
        public DateTime? RequestDate { get; set; }
        public string? RequestBy { get; set; }
        public bool? Fulfill { get; set; }
        public long? AisleId { get; set; }
        public long? SupplyerId { get; set; }
        protected override IEnumerable<object> GetIdentityComponents()
        {
            yield return Id;
        }
    }
}
