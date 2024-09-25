using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CelebrationReminderAPI.Models
{
    public class ReminderType
    {
        public int ReminderTypeId { get; set; }
        [StringLength(50)]
        public string ReminderName { get; set; }

        public ICollection<Reminder> Reminders { get; set; } = new List<Reminder>();
    }
}