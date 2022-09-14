using _0_Framework._0_Framework.Domain;

namespace Onion.Domain.AtricleAgg;

public class ArticleCategory : EntityBase<long>
{
    public ArticleCategory(string name) 
    {
        Name = name;
        IsActive = true;
    }
    public void Edit(string name , bool isActive)
    {
        Name = name;
        IsActive = isActive;
    }

    public string Name { get; set; }
    public bool IsActive { get; set; }
}
