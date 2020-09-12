using Condominios.BLL.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Condominios.DAL.Mapeamentos
{
    public class ServicoMap : IEntityTypeConfiguration<Servico>
    {
        public void Configure(EntityTypeBuilder<Servico> builder)
        {
            builder.Property(s => s.servicoId);
            builder.Property(s => s.nome).IsRequired().HasMaxLength(30);
            builder.Property(s => s.valor).IsRequired();
            builder.Property(s => s.situacao).IsRequired();
            builder.Property(s => s.usuarioId).IsRequired();

            builder.HasOne(s => s.usuario).WithMany(s => s.servicos).HasForeignKey(s => s.usuarioId);
            builder.HasMany(s => s.servicoPredio).WithOne(s => s.servico);

            builder.ToTable("Servicos");
        }
    }
}
