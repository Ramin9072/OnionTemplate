using _0_Framework._0_Framework.Domain.Domain;
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
        private readonly IBaseWorkFlowRepository _baseWorkFlowRepository;


        public ArticleCategoryApplication(IArticleCategoryRepository articleCategoryRepository,
            IResultDetails resultDetails, IBaseWorkFlowRepository baseWorkFlowRepository)
        {
            _articleCategoryRepository = articleCategoryRepository;
            _resultDetails = resultDetails;
            _baseWorkFlowRepository = baseWorkFlowRepository;
        }

        public ResultDetails Create(ArticleCategoryCreateDTO command)
        {
            try
            {
                _baseWorkFlowRepository.BeginTransaction();
                ArticleCategory category = new ArticleCategory(command.Name);
                _articleCategoryRepository.Create(category);
                _baseWorkFlowRepository.CommitTransaction();
                return _resultDetails.Success("Successfuly create");
            }
            catch (OnionException)
            {
                _baseWorkFlowRepository.RollBackTransaction();
                throw new OnionException("Cannot be saved", "0x8005F241");
            }
            
        }

        public List<ArticleCategoryDTO> List()
        {
            try
            {
                return _articleCategoryRepository.List().Select(p => new ArticleCategoryDTO
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
