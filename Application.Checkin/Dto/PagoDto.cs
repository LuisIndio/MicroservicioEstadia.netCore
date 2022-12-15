using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Estadia.Dto
{
    public class PagoDto
    {
        public Guid PagoId { get; set; }
        public double Total { get; set; }
    }
}
