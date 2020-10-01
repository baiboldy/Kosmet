using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kosmetica.Data.Models {
    public class File : Base {
        public byte[] Data { get; set; }
        [MaxLength(500)]
        public string Name { get; set; }
        public long ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}
