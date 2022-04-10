using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Enums;


namespace DelegatePart2.Models
{
    internal class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public Role Role { get; set; }
        public User(string username, string email, Role role)
        {
            Username = username;
            Email = email;
            Role = role;    
        }

        public void ShowInfo()
        {
            Console.WriteLine($"User name: {Username} \n" +
                $"Email: {Email}\n" +
                $"Role {Role}\n" +
                $"");
        }
    }
}
