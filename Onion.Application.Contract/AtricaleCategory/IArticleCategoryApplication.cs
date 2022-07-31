using _0_Framework.BaseResultState;

namespace Onion.Application.Contract.AtricaleCategory
{
    public interface IArticleCategoryApplication
    {
        ResultDetails Create(ArticleCategoryCreateDTO command);
        List<ArticleCategoryDTO> List();
    }
}