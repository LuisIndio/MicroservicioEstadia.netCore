using Domain.Estadia.Model.CreditCards;
using Domain.Estadia.Model.Facturas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Estadia.Factories.Factura
{
    public interface IFacturaFactory
    {
        Facturass CrearFactura();
        Facturass CrearFactura(string detalle, int numero, double total, string fecha);
    }
}
