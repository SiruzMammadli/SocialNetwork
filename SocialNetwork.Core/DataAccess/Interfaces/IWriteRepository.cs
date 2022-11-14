using SocialNetwork.Core.Entities.Common;

namespace SocialNetwork.Core.DataAccess.Interfaces
{
    public interface IWriteRepository<T> : IRepositoryBase<T> where T : BaseEntity, IEntity
    {
        Task AddAsync(T model);
        Task AddRangeAsync(List<T> models);
        void Update(T model);
        void Delete(T model);
        Task DeleteByIdAsync(T model);
        void DeleteRange(List<T> models);
    }
}