using Infrastructure.Estadia.EF.ReadModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Estadia.EF.Config.ReadConfig
{
    internal class CreditCardReadConfig : IEntityTypeConfiguration<CreditCardReadModel>
    {
        public void Configure(EntityTypeBuilder<CreditCardReadModel> builder)
        {
            builder.ToTable("CreditCard");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("creditCardId");

            builder.Property(x => x.TipoTarjeta)
                .HasColumnName("tipo_tarjeta");

            builder.Property(x => x.NumeroTarjeta)
                .HasColumnName("numero_tarjeta");

        }
    }
}
