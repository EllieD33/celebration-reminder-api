using System.Collections.Generic;

namespace CelebrationReminderAPI.Models
{
    public class ReminderType
    {
        public int ReminderTypeId { get; set; }
        public string ReminderName { get; set; }

        public ICollection<Reminder> Reminders { get; set; } = new List<Reminder>();
    }
}