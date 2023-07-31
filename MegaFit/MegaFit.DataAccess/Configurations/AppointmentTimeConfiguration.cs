using MegaFit.DataAccess.SeedData;
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
    public class AppointmentTimeConfiguration : IEntityTypeConfiguration<AppointmentTime>
    {
        public void Configure(EntityTypeBuilder<AppointmentTime> builder)
        {
            builder.ToTable(nameof(AppointmentTime));
            builder.HasKey(time=>time.Id);
            builder.Property(time=>time.AppointmentHour).IsRequired().HasColumnType("smallint");

            builder.HasData(
                AppointmentTimeData.AppointmentTime_01,
                AppointmentTimeData.AppointmentTime_02,
                AppointmentTimeData.AppointmentTime_03,
                AppointmentTimeData.AppointmentTime_04,
                AppointmentTimeData.AppointmentTime_05,
                AppointmentTimeData.AppointmentTime_06,
                AppointmentTimeData.AppointmentTime_07,
                AppointmentTimeData.AppointmentTime_08,
                AppointmentTimeData.AppointmentTime_09,
                AppointmentTimeData.AppointmentTime_10,
                AppointmentTimeData.AppointmentTime_11,
                AppointmentTimeData.AppointmentTime_12
                );
        }
    }
}
