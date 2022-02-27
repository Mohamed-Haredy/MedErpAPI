using MedErp.Domain.Base;

namespace MedErp.Domain.Entities
{
    public class ItemType : Entity,IAggregateRoot
    {
        public long Id { get; set; }
        public string? TypeName { get; set; }
        
       
        protected override IEnumerable<object> GetIdentityComponents()
        {
            yield return Id;
        }
    }
}
