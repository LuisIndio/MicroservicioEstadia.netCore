using Domain.Estadia.events;
using Domain.Estadia.Model.CreditCards;
using Domain.Estadia.Model.Huespedes;
using ShareKernel.Core;

namespace Domain.Estadia.Model.CheckIn
{
    public class Checkin : AggregateRoot
    {
        public Guid ReservaId { get; set; }

        public CreditCard CreditCard { get; set; }

        public Guid HabitacionId { get; set; }

        public Huesped Huesped { get; set; }

        public Guid ClienteId { get; set; }


        public Checkin(Guid reservaId, Guid habitacionId,Guid clienteId)
        {
            Id = Guid.NewGuid();
            ReservaId = reservaId;
            HabitacionId = habitacionId;
            ClienteId = clienteId;
        }
        public void EditCheckin(Guid reservaId, Guid habitacionId, Guid clienteId)
        {
            ReservaId = reservaId;
            HabitacionId = habitacionId;
            ClienteId = clienteId;
        }
        public void agregarCreditCard(string tipoTarjeta,string numeroTarjeta)
        {
            CreditCard = new CreditCard(tipoTarjeta, numeroTarjeta);
            var evento = new CreditCardAgregado(tipoTarjeta, numeroTarjeta);
            AddDomainEvent(evento);
        }
        
        public void agregarHuesped(string dni)
        {
            Huesped = new Huesped(dni);
            var evento = new HuespedAgregado(dni);
            AddDomainEvent(evento);
        }
        // Only for Entity Framework
        public Checkin() { }
    }
}
