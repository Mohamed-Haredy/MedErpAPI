using MedErp.Domain;
using MedErp.Domain.Base; 
using MedErp.Domain.Entities;
using Microsoft.Extensions.Logging; 
using MedErp.Infrastructure.Repositories; 

namespace MedErp.Infrastructure
{
    public class UnitOfWork : IUnitOfWork, IAsyncDisposable
    {
        private readonly MedErpDBContext dbContext;
        private readonly ILogger<UnitOfWork> logger;

        public UnitOfWork(IDatabaseConnectionString databaseConnectionString, ILogger<UnitOfWork> logger)
        {
            dbContext = new MedErpDBContext(databaseConnectionString.ConnectionString);
            this.logger = logger;
        }

        private IInventoryRepository inventoryRepository;
        private IItemRepository itemRepository;
        private IItemTypeRepository itemTypeRepository;
        private IVendorRepository vendorRepository;
        private IAisleRepository aisleRepository;
        private IPatientRepository patientRepository;
        private IBloodTypeRepository bloodTypeRepository;
        private IReligionRepository religionRepository;
        private ICountryRepository countryRepository;
        private IDoctorRepository doctorRepository;
        private IAdmittedPatientRepository  admittedPatientRepository;
        private IOutPatientRepository outPatientRepository;
        private IAppointmentRepository appointmentRepository;
        private IAppointmentTypeRepository appointmentTypeRepository;



        public IInventoryRepository InventoryRepository => inventoryRepository ??= new InventoryRepository(dbContext);
        public IItemRepository ItemRepository => itemRepository ??= new ItemRepository(dbContext);
        public IItemTypeRepository ItemTypeRepository => itemTypeRepository ??= new ItemTypeRepository(dbContext);
        public IVendorRepository VendorRepository => vendorRepository ??= new VendorRepository(dbContext);
        public IAisleRepository AisleRepository => aisleRepository ??= new AisleRepository(dbContext);
        public IPatientRepository PatientRepository => patientRepository ??= new PatientRepository(dbContext);
        public IBloodTypeRepository BloodTypeRepository => bloodTypeRepository ??= new BloodTypeRepository(dbContext);
        public IReligionRepository ReligionRepository => religionRepository ??= new ReligionRepository(dbContext);
        public ICountryRepository CountryRepository => countryRepository ??= new CountryRepository(dbContext);
        public IDoctorRepository DoctorRepository => doctorRepository ??= new DoctorRepository(dbContext);
        public IAdmittedPatientRepository AdmittedPatientRepository => admittedPatientRepository ??= new AdmittedPatientRepository(dbContext);
        public IOutPatientRepository OutPatientRepository => outPatientRepository ??= new OutPatientRepository(dbContext);
        public IAppointmentRepository AppointmentRepository => appointmentRepository ??= new AppointmentRepository(dbContext);
        public IAppointmentTypeRepository AppointmentTypeRepository => appointmentTypeRepository ??= new AppointmentTypeRepository(dbContext);










        public IRepository<T> AsyncRepository<T>() where T : Entity
        {
            return new RepositoryBase<T>(dbContext);
        }

        public Task<int> SaveChangesAsync()
        {
            return dbContext.SaveChangesAsync();
        }
        /// <summary>
        /// No matter an exception has been raised or not, 
        /// this method always will dispose the DbContext 
        /// </summary>
        /// <returns></returns>
        ValueTask IAsyncDisposable.DisposeAsync()
        {
            return dbContext.DisposeAsync();
        } 
    }
}