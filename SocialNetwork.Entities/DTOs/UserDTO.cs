namespace SocialNetwork.Entities.DTOs
{
    public class UserDTO
    {
        public record LoginDTO(string id, int age);
        public record RegisterDTO(string id, int age);
    }
}