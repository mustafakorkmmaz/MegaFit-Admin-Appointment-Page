using MegaFit.DataAccess.Configurations;
using MegaFit.EntityLayer.Entities;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaFit.DataAccess
{
    public class MegaContext:DbContext
    {
        public DbSet <Customer> Customers { get; set; }
        public DbSet <CustomerVisit> CustomerVisits { get; set; }
        public DbSet <CustomerAssessment> CustomerAssessments { get; set; }
        public DbSet <Therapy> Therapies { get; set; }
        public DbSet <Package> Packages { get; set; }
        public DbSet<AppointmentTime> AppointmentTimes { get; set; }
        public DbSet<Deal> Deals { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(DbSettings.ConnectionPcStringSettings);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CustomerAssessmentConfiguration());
            builder.ApplyConfiguration(new CustomerConfiguration());
            builder.ApplyConfiguration(new CustomerVisitConfiguration());
            builder.ApplyConfiguration(new TherapyConfiguration());
            builder.ApplyConfiguration(new PackageConfiguration());
            builder.ApplyConfiguration(new AppointmentTimeConfiguration());
            builder.ApplyConfiguration(new DealConfigruation());
            builder.ApplyConfiguration(new AppointmentConfiguration());
            
        }
    }
}
