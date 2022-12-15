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
    internal class HuespedReadConfig : IEntityTypeConfiguration<HuespedReadModel>
    {
        public void Configure(EntityTypeBuilder<HuespedReadModel> builder)
        {
            builder.ToTable("Huesped");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("huespedId");

            builder.Property(x => x.Dni)
                .HasColumnName("dni");

        }
    }
}
