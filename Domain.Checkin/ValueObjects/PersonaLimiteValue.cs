using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Ventas.ValueObjects
{
    public record PersonaLimiteValue : ValueObject
    {
        public int Value { get; init; }

        public PersonaLimiteValue(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("El limite persona no puede ser negativo");
            }
            Value = value;
        }

        public static implicit operator int(PersonaLimiteValue limitepersona) => limitepersona == null ? 0 : limitepersona.Value;
        public static implicit operator PersonaLimiteValue(int limitepersona) => new (limitepersona);
    }
}
