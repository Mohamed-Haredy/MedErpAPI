﻿using MedErp.Domain;
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


        public IInventoryRepository InventoryRepository => inventoryRepository ??= new InventoryRepository(dbContext);


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