using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectTemplate.Domain.Models;
using System;

namespace ProjectTemplate.Repository.ModelsConfiguration
{
    public class EntityNameConfig : IEntityTypeConfiguration<EntityName>
    {
        public void Configure(EntityTypeBuilder<EntityName> builder)
        {
            
        }
    }
}
