using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kosmetica.Data.Models {
    public class Category : Base {
        [MaxLength(500)]
        public string Name { get; set; }
        public IList<Product> Products { get; set; } = new List<Product>();
    }
}
