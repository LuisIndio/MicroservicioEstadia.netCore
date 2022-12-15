using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Estadia.Dto
{
    public class CreditCardDto
    {
        public Guid CreditCardId { get; set; }

        public string TipoTarjeta { get; set; }

        public string NumeroTarjeta { get; set; }
    }
}
