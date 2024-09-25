using System.ComponentModel.DataAnnotations;

namespace CelebrationReminderAPI.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        public int UserId { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(50)]
        public string Nickname { get; set; }
        [StringLength(15)]
        public string PhoneNumber { get; set; }
        [EmailAddress]
        [StringLength(254)]
        public string EmailAddress { get; set; }
        public int AddressId { get; set; }
        public int RelationshipTypeId { get; set; }

        public User User { get; set; }
        public Address Address { get; set; }
        public RelationshipType RelationshipType { get; set; }
    }
}