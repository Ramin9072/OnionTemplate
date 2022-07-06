using _0_Framework._0_Framework.Domain._0_Framework.Infrastracture.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Domain.AtricleAgg
{
    public interface IArticleCategoryRepository : IRepository<long,ArticleCategory>
    {
        List<ArticleCategory> search(string name);
    }
}
 