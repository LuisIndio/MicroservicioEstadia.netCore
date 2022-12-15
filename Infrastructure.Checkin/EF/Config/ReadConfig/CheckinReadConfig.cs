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
    internal class CheckinReadConfig : IEntityTypeConfiguration<CheckinReadModel>
    {
        public void Configure(EntityTypeBuilder<CheckinReadModel> builder)
        {
            builder.ToTable("Checkin");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("checkinId");

            builder.Property(x => x.ReservaId).HasColumnName("reservaId");

            builder.Property(x => x.HabitacionId).HasColumnName("habitacionId");
            builder.HasOne(x => x.Habitacion).WithMany().HasForeignKey(x => x.HabitacionId);

            builder.Property(x => x.ClienteId).HasColumnName("clienteId");

            builder.HasOne(x => x.CreditCard).WithMany().HasForeignKey(x => x.CreditCardId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Huesped).WithMany().HasForeignKey(x => x.HuespedId).OnDelete(DeleteBehavior.NoAction);



            //builder.Property(preserva => preserva.Estadia).HasColumnName("estadia");
            //builder.HasMany(preserva => preserva.Estadia).WithOne(preserva => preserva.Reserva).HasForeignKey(preserva => preserva.ReservaId);
        }
    }
}
