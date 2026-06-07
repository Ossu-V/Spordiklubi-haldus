using Microsoft.EntityFrameworkCore;
using Spordiklubi_haldus.Models;
using System.Reflection.Emit;

namespace Spordiklubi_haldus.Data
{
    public class SpordiklubiHaldusContext : DbContext
    {
        public SpordiklubiHaldusContext(
            DbContextOptions<SpordiklubiHaldusContext> options)
            : base(options)
        {
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<Sport> Sports { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<Registration> Registrations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>().ToTable("Member");
            modelBuilder.Entity<Membership>().ToTable("Membership");
            modelBuilder.Entity<Sport>().ToTable("Sport");
            modelBuilder.Entity<Training>().ToTable("Training");
            modelBuilder.Entity<Registration>().ToTable("Registration");

            modelBuilder.Entity<Registration>()
                .HasKey(r => new
                {
                    r.MemberId,
                    r.TrainingId
                });
        }
    }
}