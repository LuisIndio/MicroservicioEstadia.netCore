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
    internal class CheckoutReadConfig : IEntityTypeConfiguration<CheckoutReadModel>
    {
        public void Configure(EntityTypeBuilder<CheckoutReadModel> builder)
        {
            builder.ToTable("Checkout");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("checkoutId");

            builder.Property(x => x.ClienteId).HasColumnName("clienteId");

            builder.Property(x => x.CreditCardId).HasColumnName("creditCardId");
            builder.HasOne(x => x.CreditCard).WithMany().HasForeignKey(x => x.CreditCardId);

            builder.Property(x => x.CheckinId).HasColumnName("checkinId");
            builder.HasOne(x => x.Checkin).WithMany().HasForeignKey(x => x.CheckinId);


            builder.HasOne(x => x.Factura).WithMany().HasForeignKey(x => x.FacturaId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Pago).WithMany().HasForeignKey(x => x.PagoId).OnDelete(DeleteBehavior.NoAction);



            //builder.Property(preserva => preserva.Estadia).HasColumnName("estadia");
            //builder.HasMany(preserva => preserva.Estadia).WithOne(preserva => preserva.Reserva).HasForeignKey(preserva => preserva.ReservaId);
        }
    }
}
