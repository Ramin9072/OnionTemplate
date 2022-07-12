namespace _0_Framework._0_Framework.Domain
{
    public class EntityBase<T>
    {
        public EntityBase()
        {
            DateTime = DateTime.Now;
        }

        public T Id { get; set; }
        public DateTime DateTime { get; set; }

    }
}
