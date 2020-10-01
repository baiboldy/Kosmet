using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kosmetica.Data.Models {
    public class Product : Base {
        [Required]
        [MaxLength(500)]
        public long FullName { get; set; }
        public decimal Price { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        public long CategoryId { get; set; }
        public IList<File> File { get; set; }
        //Производство
        //состав
        //оценка товара
        //отзывы

    }
}
