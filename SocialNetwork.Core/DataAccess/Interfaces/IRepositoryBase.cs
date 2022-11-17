using System.Linq.Expressions;
using SocialNetwork.Core.Entities.Common;

namespace SocialNetwork.Core.DataAccess.Interfaces
{
    public interface IRepositoryBase<T> where T : BaseEntity, IEntity
    {
        Task AddAsync(T model);
        Task AddRangeAsync(List<T> models);
        void Update(T model);
        void Delete(T model);
        Task DeleteByIdAsync(string id);
        void DeleteRange(List<T> models);
        IEnumerable<T> GetList(Expression<Func<T, bool>>? method, bool tracking = true);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true);
        Task<T> GetByIdAsync(string id, bool tracking = true);
    }
}