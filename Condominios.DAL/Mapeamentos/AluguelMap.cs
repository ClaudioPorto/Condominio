using Condominios.BLL.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Condominios.DAL.Mapeamentos
{
    public class AluguelMap : IEntityTypeConfiguration<Aluguel>
    {
        public void Configure(EntityTypeBuilder<Aluguel> builder)
        {
            builder.HasKey(a => a.aluguelId);
            builder.Property(a => a.valor).IsRequired();
            builder.Property(a => a.mesId).IsRequired();
            builder.Property(a => a.ano).IsRequired();

            builder.HasOne(a => a.mes).WithMany(a => a.alugueis).HasForeignKey(a => a.mesId);
            builder.HasMany(a => a.pagamentos).WithOne(a => a.aluguel);

            builder.ToTable("Alugueis");
        }
    }
}
