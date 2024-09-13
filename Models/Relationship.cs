using System.Collections.Generic;

namespace CelebrationReminderAPI.Models
{
    public class Relationship
    {
        public int RelationshipId { get; set; }
        public string Relationship { get; set; }

        public ICollection<Contact> Contacts { get; set; } = new List<Contact>();
    }
}