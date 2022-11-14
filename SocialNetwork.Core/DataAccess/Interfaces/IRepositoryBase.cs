using SocialNetwork.Core.Entities.Common;

namespace SocialNetwork.Core.DataAccess.Interfaces
{
    public interface IRepositoryBase<T> where T : BaseEntity, IEntity
    {
        
    }
}