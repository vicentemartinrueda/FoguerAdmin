using System;
using Database.General.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.General.Configuration
{
    class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(e => e.Id);

            //Añadido Query Filter en la tabla Usuario
            //builder.HasQueryFilter(b => b.EstadosId != (int)EstadosEnumeration.Desactivado);
        }
    }
}
