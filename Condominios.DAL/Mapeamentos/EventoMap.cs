using Condominios.BLL.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Condominios.DAL.Mapeamentos
{
    public class EventoMap : IEntityTypeConfiguration<Evento>
    {
        public void Configure(EntityTypeBuilder<Evento> builder)
        {
            builder.HasKey(e => e.eventoId);
            builder.Property(e => e.nome).IsRequired().HasMaxLength(50);
            builder.Property(e => e.data).IsRequired();
            builder.Property(e => e.usuarioId).IsRequired();

            builder.HasOne(e => e.usuario).WithMany(e => e.eventos).HasForeignKey(e => e.usuarioId);

            builder.ToTable("Eventos");
        }
    }
}
