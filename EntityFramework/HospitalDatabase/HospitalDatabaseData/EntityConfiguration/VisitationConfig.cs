using HospitalDatabaseDataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalDatabaseData.EntityConfiguration
{
    public class VisitationConfig : IEntityTypeConfiguration<Visitation>
    {
        public void Configure(EntityTypeBuilder<Visitation> builder)
        {
            builder.HasKey(v => v.VisitationId);

            builder.Property(d => d.Date);
                
            builder.Property(c => c.Comments)
                .HasMaxLength(250)
                .IsUnicode();
        }
    }
}
