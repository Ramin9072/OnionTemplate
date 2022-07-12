using Onion.Infrastracture.EFCore;

namespace _0_Framework._0_Framework.Domain.Domain
{
    internal class BaseWorkFlow : IBaseWorkFlowRepository
    {
        private readonly OnionContext dbContext; 
        public void BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public void RollBackTransaction()
        {
            throw new NotImplementedException();
        }

        public void CommitTransaction()
        {
            throw new NotImplementedException();
        }

        public void CloseTransaction()
        {
            throw new NotImplementedException();
        }
    }
}
