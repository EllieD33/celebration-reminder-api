using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace CelebrationReminderAPI.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Required]
        [StringLength(50)]
        public string Username { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(254)]
        public string Email { get; set; }
        [Required]
        [StringLength(128)]
        public string PasswordHash { get; set; }
        public int CountryId { get; set; }
        public int RoleId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Country Country { get; set; }
        public Role Role { get; set; }
        public ICollection<Event> Events { get; set; } = new List<Event>();
    }
}