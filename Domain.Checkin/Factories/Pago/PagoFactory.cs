using Domain.Estadia.Model.Facturas;
using Domain.Estadia.Model.Pagos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Estadia.Factories.Pago
{
    public class PagoFactory : IPagoFactory
    {
        public Pagoss CrearPago()
        {
            return new Pagoss();       
        }

        public Pagoss CrearPago(double total)
        {
            return new Pagoss(total);
        }
    }
}
