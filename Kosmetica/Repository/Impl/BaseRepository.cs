using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kosmetica.Data.Models;
using Kosmetica.Repository.Interface;
using Kosmetica.Service;
using Microsoft.EntityFrameworkCore;

namespace Kosmetica.Repository.Impl {
    public class BaseRepository<T> : IBaseRepository<T> where T : class, IBase {
        private readonly AppDBContext _appDbContext;

        public BaseRepository(AppDBContext appDbContext) {
            _appDbContext = appDbContext;
        }
        public IQueryable<T> getAll() {
            return _appDbContext.Set<T>();
        }

        public async Task<T> getById(long id) {
            return await _appDbContext.Set<T>().Where(model => model.Id == id).FirstOrDefaultAsync();
        }

        public async Task<bool> delete(long id) {
            try {
                var res = await _appDbContext.Set<T>().Where(model => model.Id == id && !model.IsDeleted).FirstOrDefaultAsync();
                _appDbContext.Set<T>().Remove(res);
                await _appDbContext.SaveChangesAsync();
                return true;
            } catch (Exception e) {
                Console.WriteLine(e);
                return false;
            }
        }

        public async Task<bool> update(T model) {
            try {
                var result = _appDbContext.Update(model);
                await _appDbContext.SaveChangesAsync();
                if (result.Entity != null) {
                    return true;
                }
                return false;
            } catch (Exception e) {
                Console.WriteLine(e);
                return false;
            }
        }

        public async Task<long> create(T model) {
            try {
                var res = await _appDbContext.Set<T>().AddAsync(model);
                await _appDbContext.SaveChangesAsync();
                return res.Entity.Id;
            } catch (Exception e) {
                Console.WriteLine(e);
                return (long) 0;
            }
        }
    }
}
