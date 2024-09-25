using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CelebrationReminderAPI.Models
{
    public class Country
    {
        public int CountryId {get; set; }
        [StringLength(100)]
        public string CountryName { get; set; }

        public ICollection<User> Users { get; set; } = new List<User>();
        public ICollection<Address> Addresses { get; set; } = new List<Address>();
    }
}