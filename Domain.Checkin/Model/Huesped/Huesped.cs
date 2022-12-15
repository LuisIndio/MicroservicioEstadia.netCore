using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Estadia.Model.Huespedes
{
    public class Huesped : Entity
    {
        //public Guid ClienteId { get; private set; }
        public string Dni { get;  private set; }

        public Huesped(string dni) : base()
        {
            Id = Guid.NewGuid();
            Dni = dni;
        }
        
        // Only for Entity Framework
        public Huesped() { }

    }
}
