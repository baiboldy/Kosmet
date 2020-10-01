using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kosmetica.Data.Models;
using Kosmetica.Service;

namespace Kosmetica.Repository.Impl {
    public class FileRepository : BaseRepository<File> {
        public FileRepository(AppDBContext appDbContext) : base(appDbContext) {
        }
    }
}
