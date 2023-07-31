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
    public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.ToTable(nameof(Appointment));
            builder.HasKey(x => x.Id);

            builder.Property(x=>x.IsCompleted).IsRequired().HasColumnType("bit");
            builder.Property(x => x.AppointmentDate).IsRequired().HasColumnType("datetime2(0)");

            builder.HasOne(x => x.Deal)
                   .WithMany()
                   .HasForeignKey(x => x.DealId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
