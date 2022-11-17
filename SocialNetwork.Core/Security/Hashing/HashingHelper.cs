using System.Security.Cryptography;
using System.Text;

namespace SocialNetwork.Core.Security.Hashing
{
    public static class HashingHelper
    {
        public static void HashPassword(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using var hash = new HMACSHA512();
            passwordSalt = hash.Key;
            passwordHash = hash.ComputeHash(Encoding.UTF8.GetBytes(password));
        }

        public static bool VerifyPassword(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using var hash = new HMACSHA512(passwordSalt);
            var hashedPassword = hash.ComputeHash(Encoding.UTF8.GetBytes(password));
            for (int i = 0; i < passwordHash.Length; i++)
            {
                if (hashedPassword[i] != passwordHash[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}