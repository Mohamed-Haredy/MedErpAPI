using MedErp.Domain.Base;

namespace MedErp.Domain.Entities
{
    public class Vendor : Entity,IAggregateRoot
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? AddressLocation { get; set; }
        public string? Description { get; set; }
        public int? VendorItemNumber { get; set; }

       
        protected override IEnumerable<object> GetIdentityComponents()
        {
            yield return Id;
        }
    }
}
