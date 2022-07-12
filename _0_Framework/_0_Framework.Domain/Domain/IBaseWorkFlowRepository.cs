using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Framework._0_Framework.Domain.Domain
{
    public interface IBaseWorkFlowRepository
    {
        void BeginTransaction();
        void CommitTransaction();
        void RollBackTransaction();
    }
}
