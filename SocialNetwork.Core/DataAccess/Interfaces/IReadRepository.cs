using System.Linq.Expressions;
using SocialNetwork.Core.Entities.Common;

namespace SocialNetwork.Core.DataAccess.Interfaces
{
    public interface IReadRepository<T> : IRepositoryBase<T> where T : BaseEntity, IEntity
    {
        // IEnumerable<T> GetAll(Expression<Func<T,bool>> method, bool tracking = true);
    }
}