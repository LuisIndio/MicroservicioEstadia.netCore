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
    internal class HabitacionReadConfig : IEntityTypeConfiguration<HabitacionReadModel>
    {
        public void Configure(EntityTypeBuilder<HabitacionReadModel> builder)
        {
            builder.ToTable("Habitacion");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("habitacionId");

            builder.Property(x => x.CodigoHabitacion)
                .HasColumnName("codigo_habitacion");

            builder.Property(x => x.LimitePersona)
                .HasColumnName("limite_persona");

            builder.Property(x => x.TipoHabitacion)
                .HasColumnName("tipo_habitacion");

            builder.Property(x => x.PrecioHabitacion)
                .HasColumnName("precio_habitacion");

            builder.Property(x => x.NumeroHabitacion)
                .HasColumnName("numero_habitacion");

            builder.Property(x => x.CaracteristicasHabitacion)
                .HasColumnName("caracteristica_habitacion");

            builder.Property(x => x.Disponibilidad)
                .HasColumnName("disponibilidad");

        }
    }
}
