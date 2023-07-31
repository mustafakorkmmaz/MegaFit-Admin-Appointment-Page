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
    public class CustomerVisitConfiguration : IEntityTypeConfiguration<CustomerVisit>
    {
        public void Configure(EntityTypeBuilder<CustomerVisit> builder)
        {
            builder.ToTable(nameof(CustomerVisit));
            builder.HasKey(cusvis=>cusvis.Id);
            builder.Property(cusvis => cusvis.Complaint).IsRequired().HasColumnType("varchar(1000)");
            builder.Property(cusvis => cusvis.IsSick).IsRequired().HasColumnType("bit");
            builder.Property(cusvis => cusvis.SicknessList).IsRequired(false).HasColumnType("varchar(250)");
            builder.Property(cusvis => cusvis.UsingDrugs).IsRequired().HasColumnType("bit");
            builder.Property(cusvis => cusvis.VisitDate).IsRequired().HasColumnType("datetime2(0)");

            builder.HasOne(cusvis=>cusvis.Customer)
                   .WithMany()
                   .HasForeignKey(cusvis=>cusvis.CustomerId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasData(
                CustomerVisitData.CustomerVisitData_01,
                CustomerVisitData.CustomerVisitData_02,
                CustomerVisitData.CustomerVisitData_03
                );
        }
    }
}
