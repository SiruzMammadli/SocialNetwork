
using SocialNetwork.Core.Entities.Common;

namespace SocialNetwork.Core.Entities
{
    public class User : BaseEntity, IEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string ProfilePhoto { get; set; }
        public DateTime Birthday { get; set; }
        public bool IsBlocked { get; set; }
        public int FailedLogin { get; set; }
        public bool EmailConfirmed { get; set; }
        public List<UserRole> UserRoles { get; set; }
    }
}