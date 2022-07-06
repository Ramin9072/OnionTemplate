using _0_Framework._0_Framework.Domain._0_Framework.Infrastracture.EFCore;
using Onion.Domain.AtricleAgg;

namespace Onion.Infrastracture.EFCore.Repository
{
    public class ArticleCategoryRepository : RepositoryBase<long, ArticleCategory>, IArticleCategoryRepository
    {
        private readonly OnionContext _context;

        public ArticleCategoryRepository(OnionContext context) : base(context)
        {
            _context = context;
        }

        public List<ArticleCategory> search(string name)
        {
            throw new NotImplementedException();
        }
    }
}