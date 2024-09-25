using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CelebrationReminderAPI.Models
{
    public class CommemorationType
    {
        public int CommemorationTypeId { get; set; }
        [StringLength(50)]
        public string CommemorationName { get; set; }

        public ICollection<Event> Events { get; set; } = new List<Event>();
    }
}