using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransientScopedSingleton
{
    public interface ITransientService
    {
        Guid GetOperationID();
    }
}
