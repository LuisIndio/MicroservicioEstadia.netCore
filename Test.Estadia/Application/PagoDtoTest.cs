using Application.Estadia.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Estadia.Application
{
    public class PagoDtoTest
    {
        [Fact]
        public void PagoCreation_Should_Correct()
        {
            Guid PagoId = Guid.NewGuid();
            var Total = 100.0;

            PagoDto pago = new PagoDto();

            pago.PagoId = PagoId;
            pago.Total = Total;

            Assert.NotNull(pago.PagoId);
            Assert.Equal(PagoId, pago.PagoId);

            Assert.NotNull(pago.Total);
            Assert.Equal(Total, pago.Total);

        }
    }
}
