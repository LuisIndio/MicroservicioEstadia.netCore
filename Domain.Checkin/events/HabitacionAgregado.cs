using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Estadia.events
{
    public record HabitacionAgregado : DomainEvent
    {
        public string CodigoHabitacion { get; set; }

        public string LimitePersona { get; set; }

        public Guid TipoHabitacion { get; set; }

        public double PrecioHabitacion { get; set; }

        public int NumeroHabitacion { get; set; }

        public string CaracteristicasHabitacion { get; set; }

        public string Disponibilidad { get; set; }

        public HabitacionAgregado(string codigoHabitacion,string limitePersona, Guid tipoHabitacion,double precioHabitacion,int numeroHabitacion
            ,string caracteristicasHabitacion,string disponibilidad) : base(DateTime.Now)
        {
            CodigoHabitacion = codigoHabitacion;
            LimitePersona = limitePersona;
            TipoHabitacion = tipoHabitacion;
            PrecioHabitacion = precioHabitacion;
            NumeroHabitacion = numeroHabitacion;
            CaracteristicasHabitacion = caracteristicasHabitacion;
            Disponibilidad = disponibilidad;


        }

    }
}
