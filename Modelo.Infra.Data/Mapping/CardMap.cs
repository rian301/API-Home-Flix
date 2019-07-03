using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Infra.Data.Mapping
{
    public class CardMap : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder.ToTable("Card");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.titulo)
                .IsRequired()
                .HasColumnName("Titulo");

            builder.Property(c => c.descricao)
                .IsRequired()
                .HasColumnName("Descricao");

            builder.Property(c => c.link)
                .IsRequired()
                .HasColumnName("Link");
            builder.Property(c => c.imagem)
                .IsRequired()
                .HasColumnName("Imagem");
        }
    }
}
