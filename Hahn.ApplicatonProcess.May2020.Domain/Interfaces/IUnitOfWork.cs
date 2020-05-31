using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.May2020.Domain.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        IPersonRepository People { get; set; }

        void Complete();
    }
}
