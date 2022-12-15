using Domain.Estadia.Model.Facturas;
using Domain.Estadia.Model.Pagos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Estadia.Factories.Pago
{
    public interface IPagoFactory
    {
        Pagoss CrearPago();
        Pagoss CrearPago(double total);
    }
}
