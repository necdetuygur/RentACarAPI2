﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentACar2.Core.Models;

namespace RentACar2.Data.Configurations
{
    public class AliciConfiguration : IEntityTypeConfiguration<Alici>
    {
        public void Configure(EntityTypeBuilder<Alici> builder)
        {
            builder.HasKey(x => x.AliciID);
            builder.Property(x => x.AliciID).UseIdentityColumn();
            builder.Property(x => x.TCKimlikNo).IsRequired();
            builder.Property(x => x.CepTel).IsRequired();
            builder.Property(x => x.Mail).IsRequired();
            builder.ToTable("Alici");
        }
    }
}
