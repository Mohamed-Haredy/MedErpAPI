using MedErp.Domain.Base;

namespace MedErp.Domain.Entities
{
    public class OutPatient : Entity,IAggregateRoot
    {
        public long Id { get; set; }
        public long? AdmittedId { get; set; }
        public DateTime? CheckOut { get; set; }
        public string? Description { get; set; }

        protected override IEnumerable<object> GetIdentityComponents()
        {
            yield return Id;
        }
    }
}
