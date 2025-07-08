using HotelProjectEntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HotelProjectDataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ANIL;initial Catalog=HotelApi;integrated Security=True; TrustServerCertificate=True;",
                options => options.EnableRetryOnFailure());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            // Room entity'sinde trigger olduğunu belirtiyoruz
            modelBuilder.Entity<Room>().ToTable(tb => tb.HasTrigger("TR_Rooms"));
        }

        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (DbUpdateException ex) when (ex.InnerException?.Message?.Contains("OUTPUT clause") == true)
            {
                // Trigger'lar için alternatif kaydetme yöntemi
                var entries = ChangeTracker.Entries().Where(e => e.State == EntityState.Deleted).ToList();
                foreach (var entry in entries)
                {
                    entry.State = EntityState.Detached;
                    Database.ExecuteSqlRaw($"DELETE FROM {entry.Metadata.GetTableName()} WHERE {entry.Metadata.FindPrimaryKey().Properties.First().Name} = {entry.Property(entry.Metadata.FindPrimaryKey().Properties.First().Name).CurrentValue}");
                }
                return entries.Count;
            }
        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<SendMessage> SendMessages { get; set; }
        public DbSet<MessageCategory> MessageCategories { get; set; }
        public DbSet<WorkLocation> WorkLocations { get; set; }
    }
}
