using System;
using Database.General.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Database.General.Configuration
{
    class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(e => e.IdUsuario);

            //Añadido Query Filter en la tabla Usuario
            //builder.HasQueryFilter(b => b.EstadosId != (int)EstadosEnumeration.Desactivado);
        }
    }
}
