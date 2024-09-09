using System.ComponentModel.DataAnnotations;

namespace CelebrationReminderAPI.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        [Required]
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string StreetLine3 { get; set; }
        [Required]
        public string City { get; set; }
        public string State { get; set; }
        [Required]
        public string PostalCode { get; set; }
        [Required]
        public int CountryId { get; set; }

        public Country Country { get; set; }
    }
}