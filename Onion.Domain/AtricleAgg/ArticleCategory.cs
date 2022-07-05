namespace Onion.Domain.AtricleAgg
{
    public class ArticleCategory
    {
        public ArticleCategory(string name)
        {
            Name = name;
            DateTime = DateTime.Now;
            IsActive = true;
        }
        public void Edit(string name)
        {
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateTime { get; set; }
        public bool IsActive { get; set; }
    }
}