using System;
using System.Threading.Tasks;

namespace LocalBusinessApi
{
    public class User
    {
        public string Username { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; } = new byte[0];
        public byte[] PasswordSalt { get; set; }
    }
}