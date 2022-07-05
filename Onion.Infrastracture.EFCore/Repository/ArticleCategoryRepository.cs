using Onion.Domain.AtricleAgg;

namespace Onion.Infrastracture.EFCore.Repository
{
    public class ArticleCategoryRepository : IArticleCategoryRepository
    {
        private readonly OnionContext _context;

        public ArticleCategoryRepository(OnionContext context)
        {
            _context = context;
        }

        public void Create(ArticleCategory articleCategory)
        {
            _context.ArticleCategory.Add(articleCategory);
            _context.SaveChanges();
        }

        public List<ArticleCategory> List()
        {
            return _context.ArticleCategory.ToList();
        }
    }
}