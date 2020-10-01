using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kosmetica.Data.Models {
    public class Category : Base {
        public long Id { get; set; }
        public bool IsDeleted { get; set; }
        public string Name { get; set; }
        public IList<Product> Products { get; set; } = new List<Product>();
    }
}
