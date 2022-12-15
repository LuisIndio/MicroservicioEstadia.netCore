using Domain.Estadia.Model.Habitacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Estadia.Factories
{
    public interface IHabitacionFactory
    {
        Habitacion CrearHabitacion();
        Habitacion CrearHabitacion(Guid? habitacionId, string codigoHabitacion, int limitePersona, Guid tipoHabitacion, double precioHabitacion, int numeroHabitacion, string caracteristicasHabitacion, string disponibilidad);
    }
}
