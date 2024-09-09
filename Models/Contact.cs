using System.ComponentModel.DataAnnotations;

namespace CelebrationReminderAPI.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        [Required]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }
        public string PhoneNumber { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }
        public int AddressId { get; set; }

        public User User { get; set; }
        public Address Address { get; set; }
    }
}