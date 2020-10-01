using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kosmetica.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Kosmetica.Service {
    public class AppDBContext : DbContext {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) {
            
        }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
