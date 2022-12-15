using Domain.Estadia.Model.Habitacion;
using Domain.Estadia.ValueObjects;

namespace Test.Estadia.Domain
{
    public class UnitTest1
    {
        [Fact]
        public void HabitacionCreation_Should_Correct()
        {
            var CodigoHabitacion = "123";
            var LimitePersona = 5;
            Guid TipoHabitacion = Guid.NewGuid();
            PrecioValue PrecioHabitacion = 15.5;
            var NumeroHabitacion = 10;
            var CaracteristicasHabitacion = "esta sucia";
            var Disponibilidad = "ocupada";

            Habitacion habitacion = new Habitacion(CodigoHabitacion, LimitePersona, TipoHabitacion, PrecioHabitacion, NumeroHabitacion, CaracteristicasHabitacion, Disponibilidad);

            Assert.NotNull(habitacion.CodigoHabitacion);
            Assert.Equal(CodigoHabitacion, habitacion.CodigoHabitacion);

            Assert.NotNull(habitacion.LimitePersona);
            Assert.Equal(LimitePersona, (int)habitacion.LimitePersona);

            Assert.NotNull(habitacion.TipoHabitacion);
            Assert.Equal(TipoHabitacion, habitacion.TipoHabitacion);

            Assert.NotNull(habitacion.PrecioHabitacion);
            Assert.Equal(PrecioHabitacion, habitacion.PrecioHabitacion);

            Assert.NotNull(habitacion.NumeroHabitacion);
            Assert.Equal(NumeroHabitacion, habitacion.NumeroHabitacion);

            Assert.NotNull(habitacion.CaracteristicasHabitacion);
            Assert.Equal(CaracteristicasHabitacion, habitacion.CaracteristicasHabitacion);

            Assert.NotNull(habitacion.Disponibilidad);
            Assert.Equal(Disponibilidad, habitacion.Disponibilidad);


        }
    }
}