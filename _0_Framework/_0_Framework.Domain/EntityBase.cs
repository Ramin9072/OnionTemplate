namespace _0_Framework._0_Framework.Domain
{
    public class EntityBase
    {
        public EntityBase()
        {
            DateTime = DateTime.Now;
        }

        public long Id { get; set; }
        public DateTime DateTime { get; set; }

    }
}
