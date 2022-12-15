using Domain.Estadia.Model.CheckIn;
using Domain.Estadia.Model.CheckOut;
using Domain.Estadia.Model.CreditCards;
using Domain.Estadia.Model.Facturas;
using Domain.Estadia.Model.Habitacion;
using Domain.Estadia.Model.Huespedes;
using Domain.Estadia.Model.Pagos;
using Infrastructure.Estadia.EF.Config.ReadConfig;
using Infrastructure.Estadia.EF.Config.WriteConfig;
using Infrastructure.Estadia.EF.ReadModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Estadia.EF.Context
{
    internal class WriteDbContext : DbContext
    {
        public virtual DbSet<Checkin> Checkin { get; set; }
        public virtual DbSet<Habitacion> Habitacion { get; set; }
        public virtual DbSet<Checkout> Checkout { get; set; }


        public WriteDbContext(DbContextOptions<WriteDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration<Checkin>(new CheckinWriteConfig());
            modelBuilder.ApplyConfiguration<CreditCard>(new CreditCardWriteConfig());
            modelBuilder.ApplyConfiguration<Habitacion>(new HabitacionWriteConfig());
            modelBuilder.ApplyConfiguration<Huesped>(new HuespedWriteConfig());
            modelBuilder.ApplyConfiguration<Checkout>(new CheckoutWriteConfig());
            modelBuilder.ApplyConfiguration<Facturass>(new FacturaWriteConfig());
            modelBuilder.ApplyConfiguration<Pagoss>(new PagoWriteConfig());


        }
    }
}
