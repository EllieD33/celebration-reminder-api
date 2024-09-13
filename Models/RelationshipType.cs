using System.Collections.Generic;

namespace CelebrationReminderAPI.Models
{
    public class RelationshipType
    {
        public int RelationshipTypeId { get; set; }
        public string RelationshipType { get; set; }

        public ICollection<Contact> Contacts { get; set; } = new List<Contact>();
    }
}