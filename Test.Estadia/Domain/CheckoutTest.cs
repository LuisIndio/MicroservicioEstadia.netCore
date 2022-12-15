using Domain.Estadia.Model.CheckIn;
using Domain.Estadia.Model.CheckOut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Estadia.Domain
{
    public class CheckoutTest
    {
        [Fact]
        public void CheckoutCreation_Should_Correct()
        {
            var CheckinId = Guid.NewGuid();
            var CreditCardId = Guid.NewGuid();
            var ClienteId = Guid.NewGuid();

            Checkout checkout = new Checkout(ClienteId, CreditCardId, CheckinId);

            Assert.NotNull(checkout.CreditCardId);
            Assert.Equal(CreditCardId, checkout.CreditCardId);

            Assert.NotNull(checkout.CheckInId);
            Assert.Equal(CheckinId, checkout.CheckInId);

            Assert.NotNull(checkout.ClienteId);
            Assert.Equal(ClienteId, checkout.ClienteId);


        }
    }
}
