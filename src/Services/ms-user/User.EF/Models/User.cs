using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.EF.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public string? Email { get; set; }
        public string? FullName { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public List<UserRole> UserRoles { get; set; } = new();

    }
}
