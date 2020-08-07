using System;
namespace Web.Core.Interfaces
{
    public interface IDataService
    {
        Task<TEntity> GetRecord(Guid id);
    }
}
