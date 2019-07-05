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

            builder.Property(c => c.Titulo)
                .IsRequired()
                .HasColumnName("Titulo");

            builder.Property(c => c.Descricao)
                .IsRequired()
                .HasColumnName("Descricao");

            builder.Property(c => c.Link)
                .IsRequired()
                .HasColumnName("Link");

            builder.Property(c => c.Imagem)
                .IsRequired()
                .HasColumnName("Imagem");
        }
    }
}
