using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Framework._0_Framework.Domain._0_Framework.Infrastracture.EFCore
{
    public interface IRepository<Tkey,T>
    {
        void Create(T entity);
        T Edit(Tkey key);

        T Get(Tkey key);
        List<T> List();

        bool Exist(Func<T, bool> expression);

        void SaveChanges();
    }
}
