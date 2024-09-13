using System.Collections.Generic;

namespace CelebrationReminderAPI.Models
{
    public class CommemorationType
    {
        public int CommemorationTypeId { get; set; }
        public string CommemorationName { get; set; }

        public ICollection<Event> Events { get; set; } = new List<Event>();
    }
}