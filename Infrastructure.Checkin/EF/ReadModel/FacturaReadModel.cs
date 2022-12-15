using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Estadia.EF.ReadModel
{
    internal class FacturaReadModel
    {
        [Key]
        public Guid Id { get; set; }
        public string DetalleFactura { get; set; }

        public string NumeroFactura { get; set; }
        public string Total { get; set; }
        public string FechaFactura { get; set; }


    }
}
