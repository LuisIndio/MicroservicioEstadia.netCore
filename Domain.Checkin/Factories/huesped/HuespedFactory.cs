using Domain.Estadia.Model.Huespedes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Domain.Factories
{
    public class HuespedFactory : IHuespedFactory
    {
       
        public Huesped CrearHuesped(Guid? huespedId,string dni)
        {
            if (huespedId == null || huespedId == Guid.Empty)
            {
                return new Huesped();
            }
            return new Huesped(dni);
        }

        public Huesped CrearHuesped()
        {
            return new Huesped();
        }
    }
}
