using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Estadia.EF.ReadModel
{
    internal class CheckoutReadModel
    {
        [Key]
        public Guid Id { get; set; }

        public Guid ClienteId { get; set; }

        public CheckinReadModel Checkin { get; set; }
        public Guid CheckinId { get; set; }

        public CreditCardReadModel CreditCard { get; set; }
        public Guid CreditCardId { get; set; }

        public FacturaReadModel Factura { get; set; }
        public Guid FacturaId { get; set; }

        public PagoReadModel Pago { get; set; }
        public Guid PagoId { get; set; }
    }
}
