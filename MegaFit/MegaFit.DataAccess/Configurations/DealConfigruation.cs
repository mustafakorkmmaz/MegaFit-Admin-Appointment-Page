using MegaFit.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaFit.DataAccess.Configurations
{
    public class DealConfigruation : IEntityTypeConfiguration<Deal>
    {
        public void Configure(EntityTypeBuilder<Deal> builder)
        {
            builder.ToTable(nameof(Deal));  
            builder.HasKey(d => d.Id);
            builder.Property(d=>d.TotalSession).IsRequired().HasColumnType("int");
            builder.Property(d=>d.AppointmentDayFirst).IsRequired().HasColumnType("varchar(20)");
            builder.Property(d => d.AppointmentDaySecond).IsRequired().HasColumnType("varchar(20)");

            builder.HasOne(d => d.CustomerAssessment)
                   .WithMany()
                   .HasForeignKey(d => d.CustomerId)
                   .OnDelete(DeleteBehavior.NoAction);

             builder.HasOne(d=>d.Package)
                    .WithMany()
                    .HasForeignKey(d=>d.PackageId)
                    .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(d => d.AppointmentTime)
                   .WithMany()
                   .HasForeignKey(d=>d.AppointmentTimeId)
                   .OnDelete(DeleteBehavior.NoAction);


        }
    }
}
