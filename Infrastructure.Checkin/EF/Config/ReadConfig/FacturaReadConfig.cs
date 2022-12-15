using Infrastructure.Estadia.EF.ReadModel;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Estadia.EF.Config.ReadConfig
{
    internal class FacturaReadConfig : IEntityTypeConfiguration<FacturaReadModel>
    {
        public void Configure(EntityTypeBuilder<FacturaReadModel> builder)
        {
            builder.ToTable("Factura");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("facturaId");

            builder.Property(x => x.DetalleFactura)
                .HasColumnName("detalle_factura");

            builder.Property(x => x.NumeroFactura)
                .HasColumnName("numero_factura");

            builder.Property(x => x.Total)
                .HasColumnName("total");

            builder.Property(x => x.FechaFactura)
                .HasColumnName("fecha_factura");

        }
    }
}
