namespace _0_Framework._0_Framework.Domain
{
    public class EntityBase<T> // U can implement any type in domain properties for ID property
    {
        public EntityBase()
        {
            DateTime = DateTime.Now;
        }

        public T Id { get; set; }
        public DateTime DateTime { get; set; }

    }
}
