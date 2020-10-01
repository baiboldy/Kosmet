using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kosmetica.Data.Models {
    public class Product : Base {
        [Key]
        public long Id { get; set; }

        public bool IsDeleted { get; set; }

        [Required]
        [MaxLength(500)]
        public long FullName { get; set; }
        public decimal Price { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        public long CategoryId { get; set; }
        //Производство
        //состав
        //оценка товара
        //отзывы

    }
}
