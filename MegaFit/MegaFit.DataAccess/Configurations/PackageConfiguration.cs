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
    public class PackageConfiguration : IEntityTypeConfiguration<Package>
    {
        public void Configure(EntityTypeBuilder<Package> builder)
        {
            builder.ToTable(nameof(Package));
            builder.HasKey(pack => pack.Id);
            builder.Property(pack=>pack.MonthCount).IsRequired().HasColumnType("int");

            builder.HasOne(pack => pack.Therapy)
                   .WithMany()
                   .HasForeignKey(pack=>pack.TherapyId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasData(
                PackageData.Package_01,
                PackageData.Package_02,
                PackageData.Package_03,
                PackageData.Package_04,
                PackageData.Package_05,
                PackageData.Package_06,
                PackageData.Package_07,
                PackageData.Package_08,
                PackageData.Package_09
                );
        }
    }
}
