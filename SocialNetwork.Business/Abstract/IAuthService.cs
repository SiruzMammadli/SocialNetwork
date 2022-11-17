using static SocialNetwork.Entities.DTOs.UserDTO;

namespace SocialNetwork.Business.Abstract
{
    public interface IAuthService
    {
        LoginDTO Add();
    }
}