using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kosmetica.Data.Models {
    public interface IBase {
        [Key]
        long Id { get; set; }
        bool IsDeleted { get; set; }
    }
}
