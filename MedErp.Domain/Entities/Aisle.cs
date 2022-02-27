using MedErp.Domain.Base;

namespace MedErp.Domain.Entities
{
    public class Aisle : Entity,IAggregateRoot
    {
        public long Id { get; set; }
        public string? Location { get; set; }
        public string? AisleLocation { get; set; }
       
        protected override IEnumerable<object> GetIdentityComponents()
        {
            yield return Id;
        }
    }
}
