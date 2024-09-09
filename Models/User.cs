using System.ComponentModel.DataAnnotations;

namespace CelebrationReminderAPI.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string PasswordHash { get; set; }
        public int CountryId { get; set; }
        [Required]
        public int RoleId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Country Country { get; set; }
        public Role Role { get; set; }
    }
}