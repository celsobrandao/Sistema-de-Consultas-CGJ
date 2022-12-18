using System.Security.Cryptography;
using System.Text;

namespace CGJ.Infra.Utils
{
    public static class SegurancaUtils
    {
        public static string HashSHA1(string valor)
        {
            return GetSHA1HashData(valor);
        }

        private static string GetSHA1HashData(string data)
        {
            var sha1 = SHA1.Create();
            byte[] byteV = Encoding.UTF8.GetBytes(data);
            byte[] byteH = sha1.ComputeHash(byteV);

            sha1.Clear();

            return Convert.ToBase64String(byteH);
        }
    }
}
