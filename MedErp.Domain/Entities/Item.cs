using MedErp.Domain.Base;

namespace MedErp.Domain.Entities
{
    public class Item : Entity,IAggregateRoot
    {
        public long Id { get; set; }
  
        protected override IEnumerable<object> GetIdentityComponents()
        {
            yield return Id;
        }
    }
}
