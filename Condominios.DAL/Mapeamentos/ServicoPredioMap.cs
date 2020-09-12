using Condominios.BLL.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Condominios.DAL.Mapeamentos
{
    public class ServicoPredioMap : IEntityTypeConfiguration<ServicoPredio>
    {
        public void Configure(EntityTypeBuilder<ServicoPredio> builder)
        {
            builder.HasKey(s => s.servidoPredioId);
            builder.Property(s => s.servicoId).IsRequired();
            builder.Property(s => s.data).IsRequired();

            builder.HasOne(s => s.servico).WithMany(s => s.servicosPredios).HasForeignKey(s => s.servicoId);

            builder.ToTable("ServicosPredios");
        }
    }
}
