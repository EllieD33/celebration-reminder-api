using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CelebrationReminderAPI.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        [StringLength(50)]
        public string RoleName { get; set; }

        public ICollection<User> Users { get; set; } = new List<User>();
    }
}