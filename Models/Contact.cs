using System.ComponentModel.DataAnnotations;

namespace CelebrationReminderAPI.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        public int UserId { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }
        public string PhoneNumber { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }
        public int AddressId { get; set; }
        public int RelationshipId { get; set; }

        public User User { get; set; }
        public Address Address { get; set; }
        public Relationship Relationship { get; set; }
    }
}