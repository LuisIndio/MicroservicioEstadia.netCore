using Domain.Estadia.Model.CreditCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Estadia.Factories
{
    public class CreditCardFactory : ICreditCardFactory
    {
        public CreditCard CrearCreditCard()
        {
            return new CreditCard();
        }

        public CreditCard CrearCreditCard(string tipoTarjeta, string numeroTarjeta)
        {
            return new CreditCard(tipoTarjeta, numeroTarjeta);
        }
    }
}
