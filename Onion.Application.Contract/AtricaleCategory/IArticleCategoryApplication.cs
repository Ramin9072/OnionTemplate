namespace Onion.Application.Contract.AtricaleCategory
{
    public interface IArticleCategoryApplication
    {
        public void Create(ArticleCategoryCreate command);
        List<ArticleCategoryViewModel> List();
    }
}