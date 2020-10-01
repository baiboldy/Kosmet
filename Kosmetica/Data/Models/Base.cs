﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kosmetica.Data.Models {
    public abstract class Base : IBase {
        public long Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}
