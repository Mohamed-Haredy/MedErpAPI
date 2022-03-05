using MedErp.Domain.Base;

namespace MedErp.Domain.Entities
{
    public class Patient : Entity,IAggregateRoot
    {
        public long Id { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? Sex { get; set; }
        public DateTime?  DateOfBirth { get; set; }
        public string?  PlaceOfBirth { get; set; }
        public string? Jop { get; set; }
        public string? PatientType { get; set; }
        public string? PatientStatus { get; set; }
        public string? BloodType { get; set; }
        public string? ClinicSite { get; set; }
        public string? Religion { get; set; }
        public string? Guardian { get; set; }
        public int? Phone { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? Country { get; set; }



        protected override IEnumerable<object> GetIdentityComponents()
        {
            yield return Id;
        }
    }
}
