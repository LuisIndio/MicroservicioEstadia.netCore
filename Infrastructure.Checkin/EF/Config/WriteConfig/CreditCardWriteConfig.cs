using Infrastructure.Estadia.EF.ReadModel;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Estadia.Model.CreditCards;

namespace Infrastructure.Estadia.EF.Config.WriteConfig
{
    internal class CreditCardWriteConfig : IEntityTypeConfiguration<CreditCard>
    {
        public void Configure(EntityTypeBuilder<CreditCard> builder)
        {
            builder.ToTable("CreditCard");
            builder.Property(x => x.Id).HasColumnName("creditCardId");

            builder.Property(x => x.TipoTarjeta)
                .HasColumnName("tipo_tarjeta");

            builder.Property(x => x.NumeroTarjeta)
                .HasColumnName("numero_tarjeta");

            builder.Ignore(x => x.DomainEvents);
            builder.Ignore("_domainEvents");

        }
    }
}
