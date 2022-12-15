using Domain.Estadia.Model.Habitacion;
using Domain.Estadia.ValueObjects;
using Domain.Ventas.ValueObjects;
using Infrastructure.Estadia.EF.ReadModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Estadia.EF.Config.WriteConfig
{
    internal class HabitacionWriteConfig : IEntityTypeConfiguration<Habitacion>
    {
        public void Configure(EntityTypeBuilder<Habitacion> builder)
        {
            builder.ToTable("Habitacion");
            //builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("habitacionId");

            builder.Property(x => x.CodigoHabitacion)
                .HasColumnName("codigo_habitacion");

            var limiteConverter = new ValueConverter<PersonaLimiteValue, int>(
                personLimiteValue => personLimiteValue.Value,
                intValue => new PersonaLimiteValue(intValue)
            );
            builder.Property(x => x.LimitePersona)
                .HasConversion(limiteConverter)
                .HasColumnName("limite_persona");

            builder.Property(x => x.TipoHabitacion)
                .HasColumnName("tipo_habitacion");

            var precioConverter = new ValueConverter<PrecioValue, double>(
                precioValue => precioValue.Value,
                intValue => new PrecioValue(intValue)
            );

            builder.Property(x => x.PrecioHabitacion)
                 .HasConversion(precioConverter)
                .HasColumnName("precio_habitacion");

            builder.Property(x => x.NumeroHabitacion)
                .HasColumnName("numero_habitacion");

            builder.Property(x => x.CaracteristicasHabitacion)
                .HasColumnName("caracteristica_habitacion");

            builder.Property(x => x.Disponibilidad)
                .HasColumnName("disponibilidad");

            builder.Ignore(x => x.DomainEvents);
            builder.Ignore("_domainEvents");
        }
    }
}
