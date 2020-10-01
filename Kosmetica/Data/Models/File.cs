using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kosmetica.Data.Models {
    public class File : Base {
        public long Id { get; set; }
        public bool IsDeleted { get; set; }
        public byte[] Data { get; set; }
        public string Name { get; set; }
    }
}
