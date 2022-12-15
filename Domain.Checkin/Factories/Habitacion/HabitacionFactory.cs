using Domain.Estadia.Model.Habitacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Estadia.Factories
{
    public class HabitacionFactory : IHabitacionFactory
    {
        public Habitacion CrearHabitacion()
        {
            return new Habitacion();
        }

        public Habitacion CrearHabitacion(Guid? habitacionId, string codigoHabitacion, int limitePersona, Guid tipoHabitacion, double precioHabitacion, int numeroHabitacion, string caracteristicasHabitacion, string disponibilidad)
        {
            if (habitacionId == null || habitacionId == Guid.Empty)
            {
                return new Habitacion();
            }
            return new Habitacion(codigoHabitacion, limitePersona, tipoHabitacion, precioHabitacion, numeroHabitacion, caracteristicasHabitacion, disponibilidad);
        }
    }
}
