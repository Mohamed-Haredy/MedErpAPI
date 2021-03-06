using MedErp.Domain.Base;
using MedErp.Domain.Entities;
using System.Threading.Tasks;

namespace MedErp.Domain
{
    public interface IUnitOfWork
    {
        IInventoryRepository InventoryRepository { get; }
        IItemRepository ItemRepository { get; }
        IItemTypeRepository ItemTypeRepository { get; }
        IVendorRepository VendorRepository { get; }
        IAisleRepository AisleRepository { get; }
        IPatientRepository PatientRepository { get; }
        IBloodTypeRepository BloodTypeRepository { get; }
        IReligionRepository ReligionRepository { get; }
        ICountryRepository CountryRepository { get; }
        IDoctorRepository DoctorRepository { get; }
        IAdmittedPatientRepository AdmittedPatientRepository { get; }
        IOutPatientRepository OutPatientRepository { get; }
        IAppointmentRepository AppointmentRepository { get; }
        IAppointmentTypeRepository AppointmentTypeRepository { get; }





        Task<int> SaveChangesAsync();

        IRepository<T> AsyncRepository<T>() where T : Entity;
    }
     
}
