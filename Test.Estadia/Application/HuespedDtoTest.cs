using Application.Estadia.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Estadia.Application
{
    public class HuespedDtoTest
    {
        [Fact]
        public void HuespedCreation_Should_Correct()
        {
            Guid HuespedId = Guid.NewGuid();
            var Dni = "7772819";

            HuespedDto huesped = new HuespedDto();

            huesped.Dni = Dni;
            huesped.HuespedId = HuespedId;

            Assert.NotNull(huesped.HuespedId);
            Assert.Equal(HuespedId, huesped.HuespedId);

            Assert.NotNull(huesped.Dni);
            Assert.Equal(Dni, huesped.Dni);

        }
    }
}
