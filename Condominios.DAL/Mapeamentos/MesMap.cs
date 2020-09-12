using Condominios.BLL.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Condominios.DAL.Mapeamentos
{
    public class MesMap : IEntityTypeConfiguration<Mes>
    {
        public void Configure(EntityTypeBuilder<Mes> builder)
        {
            builder.HasKey(m => m.mesId);
            builder.Property(m => m.mesId).ValueGeneratedNever();
            builder.Property(m => m.nome).IsRequired().HasMaxLength(30);
            builder.HasIndex(m => m.nome).IsUnique();

            builder.HasMany(m => m.alugueis).WithOne(m => m.mes);
            builder.HasMany(m => m.historicosRecursos).WithOne(m => m.mes);

            builder.HasData(
                new Mes
                {
                    mesId = 1,
                    nome = "Janeiro"
                },
                new Mes
                {
                    mesId = 2,
                    nome = "Fevereiro"
                },
                new Mes
                {
                    mesId = 3,
                    nome = "Março"
                },
                new Mes
                {
                    mesId = 4,
                    nome = "Abril"
                },
                new Mes
                {
                    mesId = 5,
                    nome = "Maio"
                },
                new Mes
                {
                    mesId = 6,
                    nome = "junho"
                },
                new Mes
                {
                    mesId = 7,
                    nome = "Julho"
                },
                new Mes
                {
                    mesId = 8,
                    nome = "Agosto"
                },
                new Mes
                {
                    mesId = 9,
                    nome = "Setembro"
                },
                new Mes
                {
                    mesId = 10,
                    nome = "Outubro"
                },
                new Mes
                {
                    mesId = 11,
                    nome = "Novembro"
                },
                new Mes
                {
                    mesId = 12,
                    nome = "Dezembro"
                });
            builder.ToTable("Meses");
        }
    }
}
