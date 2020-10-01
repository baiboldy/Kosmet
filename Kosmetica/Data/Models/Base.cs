using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kosmetica.Data.Models {
    public interface Base {
        long Id { get; set; }
        bool IsDeleted { get; set; }
    }
}
