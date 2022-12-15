using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Estadia.EF.ReadModel
{
    internal class CheckinReadModel
    {
        [Key]
        public Guid Id { get; set; }

        public Guid ReservaId { get; set; }

        public Guid ClienteId { get; set; }


        public CreditCardReadModel CreditCard { get; set; }
        public Guid CreditCardId { get; set; }

        public HabitacionReadModel Habitacion { get; set; }
        public Guid HabitacionId { get; set; }

        public HuespedReadModel Huesped { get; set; }
        public Guid HuespedId { get; set; }
    }
}
