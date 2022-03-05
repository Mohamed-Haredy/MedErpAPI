using MedErp.Domain.Base;

namespace MedErp.Domain.Entities
{
    public class AdmittedPatient : Entity,IAggregateRoot
    {
        public long Id { get; set; }
        public long? PatientId { get; set; }
        public long? DoctorId { get; set; }
        public DateTime? CheckIn { get; set; }
        
        public string? Description { get; set; }

        protected override IEnumerable<object> GetIdentityComponents()
        {
            yield return Id;
        }
    }
}
