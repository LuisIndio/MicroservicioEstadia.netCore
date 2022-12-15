using Domain.Estadia.Model.CheckIn;
using Domain.Estadia.Model.CheckOut;
using Domain.Estadia.Model.CreditCards;
using Domain.Estadia.Model.Facturas;
using Domain.Estadia.Model.Huespedes;
using Domain.Estadia.Model.Pagos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Estadia.Factories
{
    public class CheckoutFactory : ICheckoutFactory
    {
        public Checkout CrearCheckOut()
        {
            return new Checkout();
        }

        public Checkout CrearCheckOut(Guid ClienteId, Guid CreditCardId, Facturass Factura, Pagoss Pago, Guid CheckInId)
        {
            if (ClienteId == null || CreditCardId == null || Factura == null || Pago == null || CheckInId == null)
            {
                throw new ArgumentException("Los campos para el checkin estan vacios");
            }
            return new Checkout(ClienteId, CreditCardId, CheckInId);
        }
    }
}

