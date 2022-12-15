using Domain.Estadia.Model.CheckIn;
using Domain.Estadia.Model.CreditCards;
using Domain.Estadia.Model.Habitacion;
using Domain.Estadia.Model.Huespedes;
using Domain.Estadia.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Estadia.Domain
{
    public class CheckinTest
    {
        [Fact]
        public void CheckinCreation_Should_Correct()
        {
            var ReservaId = Guid.NewGuid();
            Guid HabitacionId = Guid.NewGuid();
            var ClienteId = Guid.NewGuid();

            Checkin checkin = new Checkin(ReservaId, HabitacionId, ClienteId);

            Assert.NotNull(checkin.ReservaId);
            Assert.Equal(ReservaId, checkin.ReservaId);

            Assert.NotNull(checkin.HabitacionId);
            Assert.Equal(HabitacionId, checkin.HabitacionId);

            Assert.NotNull(checkin.ClienteId);
            Assert.Equal(ClienteId, checkin.ClienteId);


        }
    }
}
