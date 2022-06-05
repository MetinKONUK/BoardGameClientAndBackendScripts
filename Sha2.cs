using System.Security.Cryptography;
using System.Text;

namespace main
{
    public sealed class Sha2
    {
        public Sha2(){}
        public static Sha2 Instance { get; } = new Sha2();
        public static string Sha256Hash(string password)
        {
            var sb = new StringBuilder();
            using (var hash = SHA256.Create())
            {
                var enc    = Encoding.UTF8;
                var result = hash.ComputeHash(enc.GetBytes(password));
                foreach (var b in result)
                {
                    sb.Append(b.ToString("x2"));
                }
            }

            return sb.ToString();
        }
    }
}