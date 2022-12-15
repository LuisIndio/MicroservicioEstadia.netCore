using Infrastructure.Estadia.EF.ReadModel;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Estadia.Model.CheckIn;

namespace Infrastructure.Estadia.EF.Config.WriteConfig
{
    internal class CheckinWriteConfig : IEntityTypeConfiguration<Checkin>
    {
        public void Configure(EntityTypeBuilder<Checkin> builder)
        {
            builder.ToTable("Checkin");
            builder.Property(x => x.Id).HasColumnName("checkinId");

            builder.Property(x => x.ReservaId).HasColumnName("reservaId");


            builder.Property(x => x.HabitacionId).HasColumnName("habitacionId");

            builder.Property(x => x.ClienteId).HasColumnName("clienteId");

            builder.HasOne(x => x.CreditCard);
            builder.HasOne(x => x.Huesped);

            builder.Ignore(x => x.DomainEvents);
            builder.Ignore("_domainEvents");
        }
    }
}
