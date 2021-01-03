using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransientScopedSingleton
{
    public class OperationService : ITransientService, IScopedService, ISingletonService
    {
        Guid id;
        public OperationService()
        {
            id = Guid.NewGuid();
        }
        public Guid GetOperationID()
        {
            return id;
        }
    }
}
