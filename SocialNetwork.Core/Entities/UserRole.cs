using SocialNetwork.Core.Entities.Common;

namespace SocialNetwork.Core.Entities
{
    public class UserRole : BaseEntity, IEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid RoleId { get; set; }
        public Role Role { get; set; }
    }
}