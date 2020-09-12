using Condominios.BLL.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Condominios.DAL.Mapeamentos
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.Property(u => u.Id).ValueGeneratedOnAdd();
            builder.Property(u => u.cpf).IsRequired().HasMaxLength(30);
            builder.HasIndex(u => u.cpf).IsUnique();
            builder.Property(u => u.foto).IsRequired();
            builder.Property(u => u.primeiroAcesso).IsRequired();
            builder.Property(u => u.situacao).IsRequired();

            builder.HasMany(u => u.proprietarios).WithOne(u => u.proprietario);
            builder.HasMany(u => u.moradores).WithOne(u => u.morador);
            builder.HasMany(u => u.veiculos).WithOne(u => u.usuario);
            builder.HasMany(u => u.eventos).WithOne(u => u.usuario);
            builder.HasMany(u => u.pagamentos).WithOne(u => u.usuario);
            builder.HasMany(u => u.servicos).WithOne(u => u.usuario);

            builder.ToTable("Usuarios");
        }
    }
}
