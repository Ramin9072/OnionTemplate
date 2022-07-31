using _0_Framework._0_Framework.Domain;

namespace Onion.Application.Contract.AtricaleCategory
{

    public class ArticleCategoryDTO : EntityBase<long>
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public string DateTime { get; set; }
    }
}
