using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareKernel.Core
{
    public interface IUnitOfWork
    {
        Task Commit();
    }
}
