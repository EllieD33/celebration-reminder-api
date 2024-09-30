using Microsoft.EntityFrameworkCore;
using CelebrationReminderAPI.Models;

namespace CelebrationReminderAPI.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<CommemorationType> CommemorationTypes { get; set;}
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<RelationshipType> RelationshipTypes { get; set; }
        public DbSet<Reminder> Reminders { get; set; }
        public DbSet<ReminderType> ReminderTypes { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}