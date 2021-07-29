/*
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreCodeFirstSample.Models
{
    public class DictAntibioticConfiguration : IEntityTypeConfiguration<DictAntibiotic>
    {
        public void Configure(EntityTypeBuilder<DictAntibiotic> builder)
        {
            builder.ToTable("dict_antibiotics").HasKey(m => m.Id);
            builder.ToTable("dict_antibiotics").HasIndex(x => x.Name).IsUnique();

            builder
                .Property(m => m.Id)
                .HasColumnName("id")
                .HasDefaultValueSql("uuid_generate_v4()");
            builder
                .Property(m => m.Name)
                .HasColumnName("name")
                .HasDefaultValue("")
                .IsRequired()
                .HasMaxLength(1000);

            builder
                .Property(m => m.Created)
                .HasColumnName("created_at")
                .IsRequired()
                .HasDefaultValueSql("NOW()");
            builder
                .Property(m => m.Updated)
                .HasColumnName("updated_at")
                .IsRequired()
                .HasDefaultValueSql("NOW()");
        }
    }

}
*/