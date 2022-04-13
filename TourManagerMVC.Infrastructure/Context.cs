using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TourManagerMVC.Domain.Models;

namespace TourManagerMVC.Infrastructure
{
    public class Context : IdentityDbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Venue> Venues { get; set; }
        public DbSet<Concert> Concerts { get; set; } 
        public DbSet<Tour> Tours { get; set; }
        public DbSet<Address>  Addresses { get; set; } 
        public DbSet<EventsCalendar> EventsCalendars { get; set; }
        public DbSet<ArtistConcert> ArtistConcerts { get; set; }

        public Context(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Venue>()
                .HasOne<Address>(v => v.Address)
                .WithOne(a => a.Venue)
                .HasForeignKey<Address>(a => a.VenueId);
            
            builder.Entity<Venue>()
                .HasOne<EventsCalendar>(v => v.Calendar)
                .WithOne(c => c.Venue)
                .HasForeignKey<EventsCalendar>(c => c.VenueId);

            builder.Entity<EventsCalendar>()
                .HasMany(p => p.Concerts)
                .WithOne(c => c.Calendar)
                .HasForeignKey(p => p.CalendarId);

            builder.Entity<Concert>()
                .HasOne<Venue>(c => c.Venue)
                .WithMany(v => v.Concerts)
                .HasForeignKey(c => c.VenueId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Tour>()
                .HasMany(t => t.Concerts)
                .WithOne(c => c.Tour)
                .HasForeignKey(c => c.TourId);

            builder.Entity<Tour>()
                .HasOne<Artist>(t => t.Headliner)
                .WithMany(a => a.Tours)
                .HasForeignKey(t => t.ArtistId);

            builder.Entity<ArtistConcert>()
                .HasKey(ac => new { ac.ArtistId, ac.ConcertId });

            builder.Entity<ArtistConcert>()
                .HasOne<Artist>(ac => ac.Artist)
                .WithMany(a => a.ArtistConcerts)
                .HasForeignKey(ac => ac.ArtistId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<ArtistConcert>()
                .HasOne<Concert>(ac => ac.Concert)
                .WithMany(c => c.ArtistConcerts)
                .HasForeignKey(ac => ac.ConcertId)
                .OnDelete(DeleteBehavior.NoAction);
        }

    }
}
