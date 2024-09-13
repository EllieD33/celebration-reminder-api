namespace CelebrationReminderAPI.Models
{
    public class Reminder
    {
        public int ReminderId { get; set; }
        public int EventId { get; set; }
        public int ReminderTypeId { get; set; }
        public DateTime ReminderDate { get; set; }
        public TimeSpan ReminderTime { get; set; }

        public Event Event { get; set; }
        public ReminderType ReminderType { get; set; }
    }
}