using Domain.Estadia.Model.CreditCards;
using Domain.Estadia.Model.Huespedes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Estadia.Dto
{
    public class CheckinDto
    {
        public Guid CheckinId { get; set; }

        public Guid ReservaId { get; set; }

        public CreditCardDto CreditCard { get; set; }
        public Guid CreditCardId { get; set; }


        public Guid HabitacionId { get; set; }

        public HuespedDto Huesped { get; set; }

        public Guid ClienteId { get; set; }
    }
}
