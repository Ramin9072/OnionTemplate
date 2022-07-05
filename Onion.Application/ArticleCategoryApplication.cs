using Onion.Application.Contract.AtricaleCategory;
using Onion.Infrastracture.EFCore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Application
{
    public class ArticleCategoryApplication : IArticleCategoryApplication
    {
        private readonly ArticleCategoryRepository _articleCategoryRepository;

        public ArticleCategoryApplication(ArticleCategoryRepository articleCategoryRepository)
        {
            _articleCategoryRepository = articleCategoryRepository;
        }

        public void Create(ArticleCategoryCreate command)
        {
            //_articleCategoryRepository.Create(command);
        }

        public List<ArticleCategoryViewModel> List()
        {
            return null;
        }
    }
}
