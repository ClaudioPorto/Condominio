using Condominios.BLL.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Condominios.DAL.Mapeamentos
{
    public class VeiculoMap : IEntityTypeConfiguration<Veiculo>
    {
        public void Configure(EntityTypeBuilder<Veiculo> builder)
        {
            builder.HasKey(v => v.veiculoId);
            builder.Property(v => v.nome).IsRequired().HasMaxLength(30);
            builder.Property(v => v.cor).IsRequired().HasMaxLength(20);
            builder.Property(v => v.marca).IsRequired().HasMaxLength(20);
            builder.Property(v => v.placa).IsRequired().HasMaxLength(20);
            builder.Property(v => v.usuarioId).IsRequired();
            builder.HasIndex(v => v.placa).IsUnique();

            builder.HasOne(v => v.usuario).WithMany(v => v.veiculos).HasForeignKey(v => v.usuarioId);

            builder.ToTable("Veiculos");

        }
    }
}
