using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kosmetica.Service;

namespace Kosmetica.Repository {
    public class UnitOfWork : IDisposable {
        private readonly AppDBContext _appDbContext;
        private bool disposed;
        private Dictionary<string, object> repositories;

        public UnitOfWork(AppDBContext appDbContext) {
            _appDbContext = appDbContext;
        }

        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing) {
            if (!disposed) {
                if (disposing) {
                    _appDbContext.Dispose();
                }
            }
            disposed = true;
        }
        public void Save() {
            _appDbContext.SaveChanges();
        }
    }
}
