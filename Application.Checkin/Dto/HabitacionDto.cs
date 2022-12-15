using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Estadia.Dto
{
    public class HabitacionDto
    {
        public Guid HabitacionId { get; set; }

        public string CodigoHabitacion { get; set; }

        public int LimitePersona { get; set; }

        public Guid TipoHabitacion { get; set; }

        public double PrecioHabitacion { get; set; }

        public int NumeroHabitacion { get; set; }

        public string CaracteristicasHabitacion { get; set; }

        public string Disponibilidad { get; set; }
    }
}
