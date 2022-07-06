using _0_Framework.BaseResultState;
using Onion.Application.Contract.AtricaleCategory;
using Onion.Domain.AtricleAgg;
using Onion.Domain.ExceptionAgg;

namespace Onion.Application
{
    public class ArticleCategoryApplication : IArticleCategoryApplication
    {
        private readonly IArticleCategoryRepository _articleCategoryRepository;
        private readonly IResultDetails _resultDetails;


        public ArticleCategoryApplication(IArticleCategoryRepository articleCategoryRepository,
            IResultDetails resultDetails)
        {
            _articleCategoryRepository = articleCategoryRepository;
            _resultDetails = resultDetails;
        }

        public ResultDetails Create(ArticleCategoryCreate command)
        {
            ArticleCategory category = new ArticleCategory(command.Name);
            _articleCategoryRepository.Create(category);
            return _resultDetails.Success("Successfuly create");
        }

        public List<ArticleCategoryViewModel> List()
        {
            try
            {
                return _articleCategoryRepository.List().Select(p => new ArticleCategoryViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    IsActive = p.IsActive,
                    DateTime = p.DateTime.ToString()
                }).ToList();
            }
            catch (OnionException)
            {
                throw new OnionException("Fail", "500");
            }
        }
    }
}
