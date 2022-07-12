using Microsoft.EntityFrameworkCore;
using Onion.Infrastracture.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Framework._0_Framework.Domain.Domain
{
    public class BaseWorkFlowRepository : IBaseWorkFlowRepository
    {
        private readonly OnionContext _context;

        public BaseWorkFlowRepository(OnionContext Context)
        {
            _context= Context;
        }

        public void BeginTransaction()
        {
            _context.Database.BeginTransaction();
        }

        public void RollBackTransaction()
        {
            _context.Database.RollbackTransaction();
        }

        public void CommitTransaction()
        {
            _context.Database.CommitTransaction();
        }

    }
}
