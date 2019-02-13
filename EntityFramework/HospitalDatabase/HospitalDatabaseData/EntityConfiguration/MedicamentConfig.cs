using HospitalDatabaseDataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalDatabaseData.EntityConfiguration
{
    public class MedicamentConfig : IEntityTypeConfiguration<Medicament>
    {
        public void Configure(EntityTypeBuilder<Medicament> builder)
        {
            builder.HasKey(m => m.MedicamentId);

            builder.Property(n => n.Name)
                .HasMaxLength(50)
                .IsUnicode();
            builder.HasMany(x => x.Prescriptions)
                .WithOne(p => p.Medicament)
                .HasForeignKey(p => p.MedicamentId);
        }
    }
}
