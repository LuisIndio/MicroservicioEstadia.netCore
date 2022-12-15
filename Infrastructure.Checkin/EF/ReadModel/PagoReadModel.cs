using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Estadia.EF.ReadModel
{
    internal class PagoReadModel
    {
        [Key]
        public Guid Id { get; set; }
        public double Total { get; set; }
    }
}
