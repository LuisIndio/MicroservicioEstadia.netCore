using Domain.Estadia.ValueObjects;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Estadia.Model.Pagos
{
    public class Pagoss : Entity
    {
        public PrecioValue Total { get; set; }
    
        public Pagoss(double total)
        {
            Id = Guid.NewGuid();
            Total = total;
        }
        public Pagoss() { }
    }
}
