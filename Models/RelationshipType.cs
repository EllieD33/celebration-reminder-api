using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CelebrationReminderAPI.Models
{
    public class RelationshipType
    {
        public int RelationshipTypeId { get; set; }
        [StringLength(50)]
        public string RelationshipName { get; set; }

        public ICollection<Contact> Contacts { get; set; } = new List<Contact>();
    }
}