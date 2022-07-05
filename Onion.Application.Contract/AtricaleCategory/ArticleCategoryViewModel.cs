using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Application.Contract.AtricaleCategory
{

    public class ArticleCategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DateTime { get; set; }
        public bool IsActive { get; set; }
    }
}
