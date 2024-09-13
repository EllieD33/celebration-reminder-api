namespace CelebrationReminderAPI.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public int UserId { get; set; }
        public int ContactId { get; set; }
        public int CommemorationId {get; set; }
        public DateTime Date { get; set; }

        public User User { get; set; }
        public Contact Contact { get; set; }
        public Commemoration Commemoration { get; set; }
    }
}