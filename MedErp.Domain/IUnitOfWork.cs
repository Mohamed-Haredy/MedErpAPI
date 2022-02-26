using MedErp.Domain.Base;
using MedErp.Domain.Entities;
using System.Threading.Tasks;

namespace MedErp.Domain
{
    public interface IUnitOfWork
    {
        IInventoryRepository InventoryRepository { get; }








        Task<int> SaveChangesAsync();

        IRepository<T> AsyncRepository<T>() where T : Entity;
    }
     
}
