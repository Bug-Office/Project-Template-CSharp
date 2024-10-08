﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectTemplate.Domain.Models;

namespace ProjectTemplate.Repository.ModelsConfiguration
{
    public class ProfileAccessConfig : IEntityTypeConfiguration<ProfileAccess>
    {
        public void Configure(EntityTypeBuilder<ProfileAccess> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Module)
                .HasColumnType("varchar(50)");

            builder.HasOne(a => a.Profile).WithMany().HasForeignKey(fk => fk.ProfileId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
