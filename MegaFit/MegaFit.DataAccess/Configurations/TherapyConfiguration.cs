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
    public class TherapyConfiguration : IEntityTypeConfiguration<Therapy>
    {
        public void Configure(EntityTypeBuilder<Therapy> builder)
        {
            builder.ToTable(nameof(Therapy));
            builder.HasKey(th => th.Id);
            builder.Property(th=>th.Name).IsRequired().HasColumnType("varchar(20)");


            builder.HasData(
                TherapyData.Therapy_01,
                TherapyData.Therapy_02,
                TherapyData.Therapy_03
                );
        }
    }
}
