using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Estadia.Model.CreditCards
{
    public class CreditCard : Entity
    {
        public string TipoTarjeta { get; private set; }

        public string NumeroTarjeta { get; private set; }

        public CreditCard(string tipoTarjeta, string numeroTarjeta)
        {
            Id = Guid.NewGuid();
            TipoTarjeta = tipoTarjeta;
            NumeroTarjeta = numeroTarjeta;
        }
        public CreditCard() { }
    }
}
