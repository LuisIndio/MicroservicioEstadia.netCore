using Domain.Estadia.Model.CreditCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Estadia.Factories
{
    public interface ICreditCardFactory
    {
        CreditCard CrearCreditCard();
        CreditCard CrearCreditCard(string tipoTarjeta, string numeroTarjeta);
    }
}
