using Application.Estadia.Dto;
using Domain.Estadia.Model.Huespedes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Test.Estadia.Application
{
    public class CreditCardDtoTest
    {
        [Fact]
        public void CreditCardCreation_Should_Correct()
        {
            Guid CreditCardId = Guid.NewGuid();
            var TipoTarjeta = "visa";
            var NumeroTarjeta = "7772819";

            CreditCardDto creditcard = new CreditCardDto();

            creditcard.CreditCardId = CreditCardId;
            creditcard.TipoTarjeta = TipoTarjeta;
            creditcard.NumeroTarjeta = NumeroTarjeta;


            Assert.NotNull(creditcard.CreditCardId);
            Assert.Equal(CreditCardId, creditcard.CreditCardId);

            Assert.NotNull(creditcard.TipoTarjeta);
            Assert.Equal(TipoTarjeta, creditcard.TipoTarjeta);

            Assert.NotNull(creditcard.NumeroTarjeta);
            Assert.Equal(NumeroTarjeta, creditcard.NumeroTarjeta);

        }
    }
}
