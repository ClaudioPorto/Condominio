using Condominios.BLL.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Condominios.DAL.Mapeamentos
{
    public class ApartamentoMap : IEntityTypeConfiguration<Apartamento>
    {
        public void Configure(EntityTypeBuilder<Apartamento> builder)
        {
            builder.HasKey(a => a.apartamentoId);
            builder.Property(a => a.numero).IsRequired();
            builder.Property(a => a.andar).IsRequired();
            builder.Property(a => a.foto).IsRequired();
            builder.Property(a => a.proprietarioId).IsRequired();
            builder.Property(a => a.moradorId).IsRequired();

            builder.HasOne(a => a.proprietario).WithMany(a => a.proprietarios).HasForeignKey(a => a.proprietarioId);
            builder.HasOne(a => a.morador).WithMany(a => a.moradores).HasForeignKey(a => a.moradorId);

            builder.ToTable("Apartamentos");
        }
    }
}
