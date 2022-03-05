using MedErp.Domain.Base;

namespace MedErp.Domain.Entities
{
    public class Appointment : Entity,IAggregateRoot
    {
        public long Id { get; set; }
        public long? PatientId { get; set; }
        public long? DoctorId { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public string? AppointmentType { get; set; }
        public string? Location { get; set; }
        public string? Status { get; set; }
        public string? Notes { get; set; }

       
        protected override IEnumerable<object> GetIdentityComponents()
        {
            yield return Id;
        }
    }
}
