

namespace ControlTienda.Encrypt
{
    using System;
    using System.Security.Cryptography;
    using System.Text;

    

    public class Encrypting
    {
        public string GetSha256(string pass) 
        {
            SHA256 sha256 = SHA256.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream;
            StringBuilder builder = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(pass));
            for (int i = 0; i < stream.Length; i++)
                builder.AppendFormat("{0:x2}", stream[i]);
            return builder.ToString();
        }
    }
}
