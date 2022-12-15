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
    internal class PagoReadConfig : IEntityTypeConfiguration<PagoReadModel>
    {
        public void Configure(EntityTypeBuilder<PagoReadModel> builder)
        {
            builder.ToTable("Pago");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("pagoId");

            builder.Property(x => x.Total)
                .HasColumnName("total");

        }
    }
}
