using Infrastructure.Estadia.EF.Config.ReadConfig;
using Infrastructure.Estadia.EF.ReadModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Estadia.EF.Context
{
    internal class ReadDbContext : DbContext
    {
        public virtual DbSet<CheckinReadModel> Checkin { get; set; }
        public virtual DbSet<HabitacionReadModel> Habitacion { get; set; }
        public virtual DbSet<CheckoutReadModel> Checkout { get; set; }


        public ReadDbContext(DbContextOptions<ReadDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration<CheckinReadModel>(new CheckinReadConfig());
            modelBuilder.ApplyConfiguration<CheckoutReadModel>(new CheckoutReadConfig());
            modelBuilder.ApplyConfiguration<CreditCardReadModel>(new CreditCardReadConfig());
            modelBuilder.ApplyConfiguration<HabitacionReadModel>(new HabitacionReadConfig());
            modelBuilder.ApplyConfiguration<HuespedReadModel>(new HuespedReadConfig());
            modelBuilder.ApplyConfiguration<FacturaReadModel>(new FacturaReadConfig());
            modelBuilder.ApplyConfiguration<PagoReadModel>(new PagoReadConfig());


        }
    }
}
