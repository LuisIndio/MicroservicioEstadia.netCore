using Domain.Estadia.Model.CheckIn;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Estadia.Model.CheckOut;

namespace Infrastructure.Estadia.EF.Config.WriteConfig
{
    internal class CheckoutWriteConfig : IEntityTypeConfiguration<Checkout>
    {
        public void Configure(EntityTypeBuilder<Checkout> builder)
        {
            builder.ToTable("Checkout");
            builder.Property(x => x.Id).HasColumnName("checkoutId");

            builder.Property(x => x.ClienteId).HasColumnName("clienteId");

            builder.Property(x => x.CreditCardId).HasColumnName("creditCardId");

            builder.Property(x => x.CheckInId).HasColumnName("checkinId");

            builder.HasOne(x => x.Factura);
            builder.HasOne(x => x.Pago);

            builder.Ignore(x => x.DomainEvents);
            builder.Ignore("_domainEvents");
        }
    }
}
