using MegaFit.DataAccess.SeedData;
using MegaFit.EntityLayer;
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
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable(nameof(Customer));
            builder.HasKey(cus => cus.Id);
            builder.Property(cus => cus.FirstName).IsRequired().HasColumnType("varchar(30)");
            builder.Property(cus => cus.LastName).IsRequired().HasColumnType("varchar(30)");
            builder.Property(cus => cus.Age).IsRequired().HasColumnType("int");
            builder.Property(cus => cus.Weight).IsRequired().HasColumnType("int");
            builder.Property(cus => cus.Height).IsRequired().HasColumnType("int");
            builder.Property(cus => cus.CustomerAddress).IsRequired(false).HasColumnType("varchar(250)");
            builder.Property(cus => cus.IdentityNumber).IsRequired().HasColumnType("varchar(20)");
            builder.Property(cus => cus.PhoneNumber).IsRequired().HasColumnType("varchar(20)");
            builder.Property(cus => cus.EmailAddress).IsRequired(false).HasColumnType("varchar(30)");

            builder.HasData(
                CustomerData.Customer_01,
                CustomerData.Customer_02,
                CustomerData.Customer_03
                );

        }



    }
}
