using SocialNetwork.Core.DataAccess.EntityFramework;
using SocialNetwork.Core.Entities;
using SocialNetwork.DataAccess.Abstract;

namespace SocialNetwork.DataAccess.Concrete.EntityFramework
{
    public class UserDal : EfRepositoryBase<User,AppDbContext>, IUserDal
    {
        
    }
}