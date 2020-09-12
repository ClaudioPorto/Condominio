using Condominios.BLL.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Condominios.DAL.Mapeamentos
{
    public class HistoricoRecursoMap : IEntityTypeConfiguration<HistoricoRecurso>
    {
        public void Configure(EntityTypeBuilder<HistoricoRecurso> builder)
        {
            builder.HasKey(h => h.historicoRecursoId);
            builder.Property(h => h.valor).IsRequired();
            builder.Property(h => h.tipo).IsRequired();
            builder.Property(h => h.dia).IsRequired();
            builder.Property(h => h.mesId).IsRequired();
            builder.Property(h => h.ano).IsRequired();

            builder.HasOne(h => h.mes).WithMany(h => h.historicosRecursos).HasForeignKey(h => h.mesId);

            builder.ToTable("HistoricosRecursos");
        }
    }
}
