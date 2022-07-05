using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Domain.AtricleAgg
{
    public interface IArticleCategoryRepository
    {
        void Create(ArticleCategory articleCategory);
        List<ArticleCategory> List();
    }
}
 