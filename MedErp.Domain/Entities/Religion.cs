using MedErp.Domain.Base;

namespace MedErp.Domain.Entities
{
    public class Religion : Entity,IAggregateRoot
    {
        public long Id { get; set; }
        public string? ReligionName { get; set; }
        
       
        protected override IEnumerable<object> GetIdentityComponents()
        {
            yield return Id;
        }
    }
}
