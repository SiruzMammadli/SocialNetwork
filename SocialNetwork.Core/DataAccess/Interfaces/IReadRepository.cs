using SocialNetwork.Core.Entities.Common;

namespace SocialNetwork.Core.DataAccess.Interfaces
{
    public interface IReadRepository<T> : IRepositoryBase<T> where T : BaseEntity, IEntity
    {
        
    }
}