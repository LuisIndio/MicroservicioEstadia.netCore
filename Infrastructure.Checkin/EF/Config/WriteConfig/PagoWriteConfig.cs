using Infrastructure.Estadia.EF.ReadModel;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Estadia.Model.Pagos;
using Domain.Estadia.ValueObjects;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Estadia.EF.Config.WriteConfig
{
    internal class PagoWriteConfig : IEntityTypeConfiguration<Pagoss>
    {
        public void Configure(EntityTypeBuilder<Pagoss> builder)
        {
            builder.ToTable("Pago");
            builder.Property(x => x.Id).HasColumnName("pagoId");


            var precioConverter = new ValueConverter<PrecioValue, double>(
                precioValue => precioValue.Value,
                intValue => new PrecioValue(intValue)
            );

            builder.Property(x => x.Total)
                .HasConversion(precioConverter)
                .HasColumnName("total");

            builder.Ignore(x => x.DomainEvents);
            builder.Ignore("_domainEvents");
        }
    }
}
