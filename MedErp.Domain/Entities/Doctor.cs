using MedErp.Domain.Base;

namespace MedErp.Domain.Entities
{
    public class Doctor : Entity,IAggregateRoot
    {
        public long Id { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? Sex { get; set; }
        public string? ClinicSite { get; set; }
        public int? Phone { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? Country { get; set; }
        public string? SpecializationType { get; set; }

        protected override IEnumerable<object> GetIdentityComponents()
        {
            yield return Id;
        }
    }
}
