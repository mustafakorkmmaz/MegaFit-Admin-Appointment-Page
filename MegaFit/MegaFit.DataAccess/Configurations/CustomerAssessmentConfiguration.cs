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
    public class CustomerAssessmentConfiguration : IEntityTypeConfiguration<CustomerAssessment>
    {
        public void Configure(EntityTypeBuilder<CustomerAssessment> builder)
        {
            builder.ToTable(nameof(CustomerAssessment));
            builder.HasKey(ca => ca.Id);
            builder.Property(ca => ca.Evaluation).IsRequired().HasColumnType("varchar(max)");

            builder.HasOne(ca => ca.CustomerVisit)
                   .WithMany()
                   .HasForeignKey(ca => ca.VisitId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasData(
                CustomerAssessmentData.CustomerAssessment_01,
                CustomerAssessmentData.CustomerAssessment_02,
                CustomerAssessmentData.CustomerAssessment_03);
        }
    }
}
