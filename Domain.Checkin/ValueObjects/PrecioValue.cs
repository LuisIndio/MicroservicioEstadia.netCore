using Domain.Ventas.ValueObjects;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Estadia.ValueObjects
{
    public record PrecioValue : ValueObject
    {
        public double Value { get; init; }

        public PrecioValue(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException("El monto no puede ser negativo");
            }
            Value = value;
        }

        public static implicit operator double(PrecioValue precio) => precio == null ? 0 : precio.Value;
        public static implicit operator PrecioValue(double precio) => new(precio);
    }
}
