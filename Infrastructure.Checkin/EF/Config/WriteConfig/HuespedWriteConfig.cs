using Domain.Estadia.Model.Habitacion;
using Domain.Estadia.Model.Huespedes;
using Infrastructure.Estadia.EF.ReadModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Estadia.EF.Config.WriteConfig
{
    internal class HuespedWriteConfig : IEntityTypeConfiguration<Huesped>
    {
        public void Configure(EntityTypeBuilder<Huesped> builder)
        {
            builder.ToTable("Huesped");
            //builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("huespedId");

            builder.Property(x => x.Dni)
                .HasColumnName("dni");

            builder.Ignore(x => x.DomainEvents);
            builder.Ignore("_domainEvents");
        }
    }
}
