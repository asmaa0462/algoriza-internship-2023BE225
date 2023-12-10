using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryL.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        DbSet<User> Users { get; set; }
        DbSet<Doctor> Doctors { get; set; }
        DbSet<Patient> Patients { get; set; }
        DbSet<Specialization> Specializations { get; set; }
        DbSet<Appointment> Appointments { get; set; }
        DbSet<Booking> Bookings { get; set; }
        DbSet<Discount> Discounts { get; set; }
        DbSet<TimeAppointment> TimeAppointments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Doctor>()
                .HasOne<Specialization>()
                .WithMany()
                .HasForeignKey(p => p.SpecializationId);

            modelBuilder.Entity<Appointment>()
                .HasMany(m => m.Doctors)
                .WithMany(l => l.Appointments)
                .UsingEntity<DoctorsAppointments>(
                    j => j.HasOne(ml => ml.Doctor)
                          .WithMany(t => t.doctorsAppointments)
                          .HasForeignKey(ml => ml.doctorid),
                    j => j.HasOne(lm => lm.Appointment)
                          .WithMany(t => t.doctorsAppointments)
                          .HasForeignKey(lm => lm.AppointmentId),
                    j => j.HasKey(t => new { t.doctorid, t.AppointmentId }));

            modelBuilder.Entity<TimeAppointment>()
                .HasOne<Appointment>()
                .WithMany()
                .HasForeignKey(p => p.AppointmentId);

            modelBuilder.Entity<TimeAppointment>()
                .HasOne<Booking>()
                .WithMany()
                .HasForeignKey(p => p.bookId);

            modelBuilder.Entity<TimeAppointment>()
               .HasOne<Appointment>()
               .WithMany()
               .HasForeignKey(p => p.AppointmentId);

            modelBuilder.Entity<TimeAppointment>()
                .HasOne<Booking>()
                .WithMany()
                .HasForeignKey(p => p.bookId);

            modelBuilder.Entity<Booking>()
                .HasMany(m => m.Patients)
                .WithMany(l => l.Bookings)
                .UsingEntity<PatientsBookings>(
                    j => j.HasOne(ml => ml.Patient)
                          .WithMany(t => t.patientsBookings)
                          .HasForeignKey(ml => ml.PatientId),
                    j => j.HasOne(lm => lm.Booking)
                          .WithMany(t => t.patientsBookings)
                          .HasForeignKey(lm => lm.bookId),
                    j => j.HasKey(t => new { t.bookId, t.PatientId }));

            modelBuilder.Entity<Booking>()
                .HasOne<Discount>()
                .WithMany()
                .HasForeignKey(p => p.discountId);
            //Specialization Seed
            modelBuilder.seed();
            //Admin Seed doctor Data
            modelBuilder.doctorseed();

            //RolesSeed
            modelBuilder.rolesseed();

        }
    }
}
