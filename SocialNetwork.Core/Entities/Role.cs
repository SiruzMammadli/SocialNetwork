using SocialNetwork.Core.Entities.Common;

namespace SocialNetwork.Core.Entities
{
    public class Role : BaseEntity, IEntity
    {
        public string Name { get; set; }
        public List<UserRole> UserRoles { get; set; }
    }
}