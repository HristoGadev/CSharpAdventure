using HospitalDatabaseDataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalDatabaseData.EntityConfiguration
{
    public class DiagnoseConfig : IEntityTypeConfiguration<Diagnose>
    {
        public void Configure(EntityTypeBuilder<Diagnose> builder)
        {
            builder.HasKey(d => d.DiagnoseId);

            builder.Property(n => n.Name)
                .HasMaxLength(50)
                .IsUnicode();

            builder.Property(c => c.Comments)
                .HasMaxLength(250)
                .IsUnicode();
        }
    }
}
