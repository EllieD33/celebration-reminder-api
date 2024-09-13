using System.Collections.Generic;

namespace CelebrationReminderAPI.Models
{
    public class Commemoration
    {
        public int CommemorationId { get; set; }
        public string CommemorationName { get; set; }

        public ICollection<Event> Events { get; set; } = new List<Event>();
    }
}